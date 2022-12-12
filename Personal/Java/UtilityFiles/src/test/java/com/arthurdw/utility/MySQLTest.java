package com.arthurdw.utility;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

class MySQLTest {
    private static MySQL client;

    @BeforeAll
    static void creatClient() {
        client = new MySQL("tests", "root", "my-secret-pw");
    }

    @Test
    void testConnection() {
        Assertions.assertDoesNotThrow(() -> {
            client.openConnection((conn) -> {
                return null;
            });
        });
    }

    @Test
    void testPreparedStatement() {
        String query = "SELECT id FROM users WHERE id = ?";

        client.prepared(query, (conn, statement) -> {
            statement.setString(1, "1");

            try (ResultSet rs = statement.executeQuery()) {
                List<String> res = new ArrayList<String>();

                while (rs.next()) {
                    res.add(rs.getString("id"));
                }

                Assertions.assertEquals(1, res.size());
                Assertions.assertEquals("1", res.get(0));
            }

            return null;
        });
    }

    @Test
    void testPreparedStatementWithGeneratedKeys() {
        String query = "INSERT INTO users (name, email, password) VALUES (?, ?, ?)";

        client.preparedWithGeneratedKeys(query, (conn, statement) -> {
            statement.setString(1, "Arthur");
            statement.setString(2, "dev@arthurdw.com");
            statement.setString(3, "uncrackable-password");

            int affectedRows = statement.executeUpdate();

            Assertions.assertEquals(1, affectedRows);

            try (ResultSet rs = statement.getGeneratedKeys()) {
                List<String> res = new ArrayList<String>();

                while (rs.next()) {
                    res.add(rs.getString(1));
                }

                Assertions.assertEquals(1, res.size());
            }

            return null;
        });
    }
}
