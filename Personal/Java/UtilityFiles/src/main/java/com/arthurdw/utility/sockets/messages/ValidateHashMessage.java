package com.arthurdw.utility.sockets.messages;

import org.mindrot.jbcrypt.BCrypt;

import java.io.PrintStream;

public class ValidateHashMessage implements Message {
    private final String plain;
    private final String hashed;

    public ValidateHashMessage(String plain, String hashed) {
        this.plain = plain;
        this.hashed = hashed;
    }

    public ValidateHashMessage(String combined) {
        String[] split = combined.split(" ");

        if (split.length != 2) {
            throw new IllegalArgumentException("Invalid combined string");
        }

        this.plain = split[0];
        this.hashed = split[1];
    }


    @Override
    public String getMessage() {
        return String.format("Plain: %s, Hashed: %s", plain, hashed);
    }

    @Override
    public void reply(PrintStream out) {
        boolean valid = BCrypt.checkpw(plain, hashed);
        out.println("Valid: " + valid);
    }
}
