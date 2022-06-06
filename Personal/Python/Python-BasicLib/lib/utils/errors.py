# ©Arthurdw

class ExampleUtilsException(Exception):
    """The base exception class."""
    pass


class InvalidKwargsException(ExampleUtilsException):
    """Gets raised when a function/class received invalid arguments in the kwargs."""
    pass
