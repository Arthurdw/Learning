package com.arthurdw.utility.sockets.messages;

import java.io.PrintStream;
import java.io.Serializable;

public interface Message extends Serializable {
    String getMessage();

    void reply(PrintStream out);
}
