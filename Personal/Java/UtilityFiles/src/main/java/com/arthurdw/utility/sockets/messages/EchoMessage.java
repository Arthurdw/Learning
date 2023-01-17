package com.arthurdw.utility.sockets.messages;

import java.io.PrintStream;

public class EchoMessage implements Message {
    private final String message;

    public EchoMessage(String message) {
        this.message = message;
    }

    @Override
    public String getMessage() {
        return message;
    }

    @Override
    public void reply(PrintStream out) {
        out.println("You said: " + getMessage());
    }
}
