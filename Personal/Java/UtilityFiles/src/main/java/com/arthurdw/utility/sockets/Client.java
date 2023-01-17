package com.arthurdw.utility.sockets;

import com.arthurdw.utility.sockets.messages.EchoMessage;
import com.arthurdw.utility.sockets.messages.HashMessage;
import com.arthurdw.utility.sockets.messages.Message;
import com.arthurdw.utility.sockets.messages.ValidateHashMessage;

import java.io.IOException;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client {
    private static final Logger LOGGER = Logger.getLogger(Client.class.getName());

    private final String host;
    private final int port;
    private Socket socket;

    public static void main(String[] args) {
        Client client = new Client("localhost", 8080);
        client.start();
    }

    public Client(String host, int port) {
        this.host = host;
        this.port = port;
    }

    public Client(int port) {
        this("localhost", port);
    }

    public void start() {
        LOGGER.log(Level.INFO, "Trying to establish connection to {0}:{1}", new Object[]{host, port});

        try {
            socket = new Socket(host, port);
            LOGGER.log(Level.INFO, "Connected to {0}:{1}", new Object[]{host, port});
        } catch (IOException e) {
            LOGGER.log(Level.SEVERE, "Could not connect to {0}:{1}", new Object[]{host, port});
            return;
        }

        this.handleUserInput();
    }

    private void handleUserInput() {
        Scanner in = new Scanner(System.in);
        String line = in.nextLine();

        while (!line.equals("exit")) {
            LOGGER.log(Level.INFO, "Sending: {0}", line);
            try {
                this.send(line);
            } catch (IOException e) {
                LOGGER.log(Level.SEVERE, "Could not send message", e);
            }
            line = in.nextLine();
        }
    }

    private void send(String line) throws IOException {
        Scanner in = new Scanner(socket.getInputStream());
        // PrintStream out = new PrintStream(socket.getOutputStream(), true);
        // out.println(line);

        ObjectOutputStream out = new ObjectOutputStream(socket.getOutputStream());
        out.writeObject(this.getMessageType(line));

        LOGGER.log(Level.INFO, "Received: {0}", in.nextLine());
    }

    private Message getMessageType(String line) {
        if (line.length() < 5) return new EchoMessage(line);

        String noPrefix = line.trim().substring(5).trim();

        return switch (line.trim().toLowerCase().substring(0, 5)) {
            case "echo:" -> new EchoMessage(noPrefix);
            case "hash:" -> new HashMessage(noPrefix);
            case "chck:" -> new ValidateHashMessage(noPrefix);
            default -> new EchoMessage(line);
        };
    }
}
