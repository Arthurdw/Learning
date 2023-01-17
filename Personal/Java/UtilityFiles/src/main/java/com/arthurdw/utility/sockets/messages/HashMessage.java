package com.arthurdw.utility.sockets.messages;

import org.mindrot.jbcrypt.BCrypt;

import java.io.PrintStream;

public class HashMessage implements Message {
    private final String message;

    public HashMessage(String message) {
        this.message = message;
    }

    @Override
    public String getMessage() {
        return message;
    }

    @Override
    public void reply(PrintStream out) {
        String hashed = BCrypt.hashpw(getMessage(), BCrypt.gensalt());
        out.println("Hashed: " + hashed);
    }
}
