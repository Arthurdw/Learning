package com.arthurdw.utility;

import org.mindrot.jbcrypt.BCrypt;

import java.util.logging.Level;
import java.util.logging.Logger;

public class BCryptExample {
    private static final Logger LOGGER = Logger.getLogger(BCryptExample.class.getName());

    public static void main(String[] args) {
        String plain = "MyPassword";
        String hashed = BCrypt.hashpw(plain, BCrypt.gensalt());
        boolean matches = BCrypt.checkpw(plain, hashed);

        LOGGER.log(Level.INFO, "Plain: {0}", plain);
        LOGGER.log(Level.INFO, "Hashed: {0}", hashed);
        LOGGER.log(Level.INFO, "Matches: {0}", matches);
    }
}
