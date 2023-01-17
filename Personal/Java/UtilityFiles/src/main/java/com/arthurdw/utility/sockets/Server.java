package com.arthurdw.utility.sockets;

import com.arthurdw.utility.sockets.messages.Message;

import java.io.IOException;
import java.io.InputStream;
import java.io.ObjectInputStream;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {
    private static final Logger LOGGER = Logger.getLogger(Server.class.getName());
    private final int port;
    private ServerSocket socket;

    public static void main(String[] args) {
        Server server = new Server(8080);
        server.start();
    }

    public Server(int port) {
        this.port = port;
    }

    public void start() {
        LOGGER.log(Level.INFO, "Starting server on port {0}", port);
        try {
            socket = new ServerSocket(port);
            LOGGER.log(Level.INFO, "Server started on port {0}", port);
        } catch (IOException e) {
            LOGGER.log(Level.SEVERE, "Could not bind to port {0}", port);
            return;
        }

        this.handleConnections();
    }

    private void handleConnections() {
        while (true) {
            try {
                this.handleConnection();
            } catch (IOException e) {
                LOGGER.log(Level.SEVERE, "Could not handle connection", e);
            }
        }
    }

    private void handleConnection() throws IOException {
        Socket sock = socket.accept();
        LOGGER.info("Client connected from " + sock.getInetAddress().getHostAddress());

        // Scanner in = new Scanner(sock.getInputStream());
        PrintStream out = new PrintStream(sock.getOutputStream(), true);

        // while (in.hasNextLine()) {
        //     String line = in.nextLine();
        //     LOGGER.log(Level.INFO, "Received: {0}", line);
        //     out.println("You said: " + line);
        // }

        while (true) {
            try {
                ObjectInputStream in = new ObjectInputStream(sock.getInputStream());
                Message message = (Message) in.readObject();
                LOGGER.log(Level.INFO, "Received: {0}", message.getMessage());
                message.reply(out);
            } catch (ClassNotFoundException e) {
                LOGGER.log(Level.SEVERE, "Could not read message", e);
            }
        }

    }
}
