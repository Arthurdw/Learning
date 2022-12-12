package com.arthurdw.utility;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

@FunctionalInterface
interface ThrowsSQLFunction<T, R> {
    R apply(T t) throws SQLException;
}

@FunctionalInterface
interface SQLFunction<C, R> {
    R apply(C c, PreparedStatement s) throws SQLException;
}

public class MySQL {
    private static final Logger LOGGER = Logger.getLogger(MySQL.class.getName());

    private static final String JDBC_FORMAT = "jdbc:mysql://%s:%s/%s";
    private static final int DEFAULT_PORT = 3306;
    private static final String DEFAULT_HOST = "localhost";

    private final String host;
    private final int port;
    private final String database;
    private final String username;
    private final String password;

    public MySQL(String database, String username, String password) {
        this(DEFAULT_HOST, DEFAULT_PORT, database, username, password);
    }

    public MySQL(String host, String database, String username, String password) {
        this(host, DEFAULT_PORT, database, username, password);
    }

    public MySQL(String host, int port, String database, String username, String password) {
        this.host = host;
        this.port = port;
        this.database = database;

        this.username = username;
        this.password = password;
    }

    private String getJdbcUrl() {
        return String.format(JDBC_FORMAT, host, port, database);
    }

    private Connection getConnection() {
        try {
            return DriverManager.getConnection(getJdbcUrl(), username, password);
        } catch (SQLException e) {
            LOGGER.log(Level.SEVERE, String.format("Failed to connect to database: %s", e.getMessage()));
            throw new UtilityException("Failed to connect to database");
        }
    }

    public <T> T openConnection(ThrowsSQLFunction<Connection, T> function) {
        try (Connection connection = getConnection()) {
            return function.apply(connection);
        } catch (SQLException e) {
            LOGGER.log(Level.SEVERE, String.format("Failed to execute query: %s", e.getMessage()));
            throw new UtilityException("Failed to execute query");
        }
    }

    public <T> T prepared(String sql, SQLFunction<Connection, T> function) {
        return openConnection(connection -> {
            PreparedStatement statement = connection.prepareStatement(sql);
            return function.apply(connection, statement);
        });
    }

    public <T> T preparedWithGeneratedKeys(String sql, SQLFunction<Connection, T> function) {
        return openConnection(connection -> {
            PreparedStatement statement = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
            return function.apply(connection, statement);
        });
    }
}
