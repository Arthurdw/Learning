#!/bin/python3

"""
A simple brute port scanner that uses threads.
"""

import sys
import os
import socket
from threading import Thread
from typing import Iterator
from datetime import datetime
try:
    from utilsx.console import Prettier, Colors
except ModuleNotFoundError:
    print("Could not find a required module called utilsx!\n"
          "Please install utilsx using pip.\n"
          "More information can be found here: http://docs.xiler.net/utilsx#installation")
    os._exit(1)

r = Colors.red.value
y = Colors.yellow.value
d = Colors.default.value
lr = Colors.light_red.value

fatal = Prettier(default_text_format=f"{d}[{r}FATAL{d}]{lr} ")
info = Prettier()

open_ports = []

def check_port(port: int) -> None:
    """
    Checks and handles if a port is open.

    Args:
        port (int): The target port.
    """
    # info.print(f"Checking port {y + str(port)}", datetime.now())
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    socket.setdefaulttimeout(1)
    result = s.connect_ex((target, port))
    if result == 0:
        info.print(f"Port {y + str(port) + d} is open", datetime.now())
        open_ports.append(port)

def exit_program(message: str = "No Reason...") -> None:
    """
    Peacefully exits the current running program.

    Args:
        message (str, optional): The message that will be shown as reason for the exit. Defaults to "No Reason...".
    """
    fatal.print(message + d)
    os._exit(1)

try:
    if len(sys.argv) == 2:
        # Translate hostname to IPV4
        target = socket.gethostbyname(sys.argv[1])
    else:
        fatal.print("Invalid amount of arguments!")
        exit_program("Syntax: (python3|py -3) scanner.py <ip>")

    info.print(Colors.light_cyan.value + """
------------ ------------    ------    ----    ---- 
************ ************   ********   *****   **** 
----         ----          ----------  ------  ---- 
************ ****         ****    **** ************ 
------------ ----         ------------ ------------ 
       ***** ****         ************ ****  ****** 
------------ ------------ ----    ---- ----   ----- 
************ ************ ****    **** ****    ****\n""")
    info.print(f"Started scanning {y + target + d}", datetime.now())
    info.print("This can take some time, please wait.", datetime.now())

    for port in range(0, 65535):
        Thread(target=check_port, args=(port,)).start()
except KeyboardInterrupt:
    print("")
    exit_program("Keyboard interrupt received, exiting program...")
except socket.gaierror:
    exit_program("Hostname could not be resolved.")

info.print(f"Found {y + str(len(open_ports)) + d} open ports.")
info.print(", ".join([y + str(port) + d for port in open_ports]))
