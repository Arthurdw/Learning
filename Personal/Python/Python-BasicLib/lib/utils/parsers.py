# ©Arthurdw
from typing import Any, Dict, List, Union

from .errors import InvalidKwargsException
from ..user import User


def kwarg(name: str, args: Dict[str, Any]) -> Any:
    """Parses a kwarg from kwargs"""
    try:
        return args[name]
    except KeyError:
        raise InvalidKwargsException()


def parse_users(data: List[Dict[str, Union[str, List[str]]]]) -> List[User]:
    """Parse all users from a .json file"""
    def get_user(unparsed_user: Dict[str, Union[str, List[str]]]) -> User:
        get = lambda value: kwarg(value, unparsed_user)
        return User(get('username'), get('avatar'), get('github'), get('languages'))

    return [get_user(user) for user in data]
