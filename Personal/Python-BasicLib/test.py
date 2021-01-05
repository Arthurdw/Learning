from lib.client import Client, FilterMethods


def main():
    with open("./users.json", mode="r") as f:
        data = f.read()

    client = Client(data)

    user = client.get_user(FilterMethods.USERNAME, 'arthurdw')

    if not user:
        print("Couldn't find a user with the username 'arthurdw'")
        return

    print(f"Arthurdw github: {user.github}")

    print('C# programmers: ' + ', '.join(user.name for user in client.get_users_by_language('c#')))


if __name__ == "__main__":
    main()
