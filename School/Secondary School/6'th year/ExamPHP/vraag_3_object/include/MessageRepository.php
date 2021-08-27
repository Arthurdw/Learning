<?php

class MessageRepository {

    const FILENAME = "data/messages.txt";
    const SEPARATOR = "|_|";

    public function getAll() {
        $messages = array();
        foreach ($this->getLines() as $line) {
            if ($line == "") continue;
            $parts = explode(self::SEPARATOR,$line);
            $message = new Message($parts[2]);
            $message->setAuthor($parts[0])->setContent($parts[1]);
            $messages[] = $message;
        }
        return array_reverse($messages);
    }

    public function add($message) {
        $lines = $this->getLines();
        $lines[] = implode(self::SEPARATOR,array($message->getAuthor(),$message->getContent(),$message->getTime()));
        file_put_contents(self::FILENAME,implode("\n",$lines));
    }

    private function getLines() {
        $content = file_get_contents(self::FILENAME);
        return explode("\n",$content);
    }
} 