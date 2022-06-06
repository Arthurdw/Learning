#!/bin/python3

"""
A simple script that loops through the ports of a ip.

Usage:
python3 scanner.py <ip/hostname>

Created by ©Arthurdw with the fundation of TCM ♥
"""

import sys
import socket
from multiprocessing import Pool
from datetime import datetime


# Define the target
if len(sys.argv) == 2:
    # Translate hostname to IPV4
    target = socket.gethostbyname(sys.argv[1])
else:
    print("Invalid amount of arguments.\n"
          "Usage: python3 scanner.py <ip/hostname>")
    sys.exit()
    
# Print our banner
print("-+-" * 10)
print(f"Scanning target {target}")
start = datetime.now()
print(f"Time started: {start.utcnow()}")
print("-+-" * 10)
print()

try:
    def check_port(port: int) -> None:
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        socket.setdefaulttimeout(1)
        result = s.connect_ex((target, port))  # Returns an error indicator.
        if result == 0:
            print(f"Port {port} is open")
            return port
        s.close()
        
    data = Pool().map(check_port, range(1, 65536))
    open_ports = [str(i) for i in data if i is not None]
except KeyboardInterrupt:
    print("\nExiting program.")
except socket.gaierror:
    print("Hostname could not be resolved")
except socket.error:
    print("Couldn't connect to server!")
finally:
    # Print our final results
    print()
    print("-+-" * 10)
    print(f"Results for: {target}")
    print(f"Took {datetime.now() - start}")
    print(f"Found {len(open_ports)} open port(s). (listed below)" + ('\n' + ", ".join(open_ports) if open_ports else ''))
    print("-+-" * 10)

    sys.exit()
