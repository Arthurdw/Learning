# ©Arthurdw
from json import dumps
from typing import List, Dict, Union


class User:
    def __init__(self, name: str, avatar: str, github: str, languages: List[str]):
        self.name = name
        self.avatar = avatar
        self.github = github
        self.languages = languages

    def __get_dict(self) -> Dict[str, Union[str, List[str]]]:
        return dict(name=self.name, avatar=self.avatar, github=self.github, languages=self.languages)

    def __getitem__(self, item: str):
        return self.__get_dict()[item]

    def __repr__(self) -> str:
        return dumps(self.__get_dict())
