# ©Arthurdw
import functools
from enum import Enum
from json import loads
from typing import Optional, List

from .user import User
from .utils.parsers import parse_users


class FilterMethods(Enum):
    USERNAME = 'name'
    AVATAR = 'avatar'
    GITHUB = 'github'


class Client:
    def __init__(self, datafile: str):
        self.__users = parse_users(loads(datafile))

    def get_user(self, method: FilterMethods, value: str) -> Optional[User]:
        value = value.lower()
        for user in self.__users:
            if user[method.value].lower() == value:
                return user

    def get_users_by_language(self, language: str, /) -> List[User]:
        language = language.lower()
        users = []

        for user in self.__users:
            if language in list(map(lambda v: v.lower(), user.languages)):
                users.append(user)

        return users
