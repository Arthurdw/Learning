from collections import deque
from typing import Deque

items: Deque[int] = deque(maxlen=10)


def main():
    while inp := input("Enter a number: "):
        if inp == "":
            continue
        elif inp == "q":
            break

        try:
            num = int(inp)
        except ValueError:
            print("Invalid input")
            continue

        items.append(num)

    print(items)


if __name__ == "__main__":
    main()
