<?php


class Message {

    private $author;
    private $content;
    private $time;

    public function __construct($time = null) {
        $now = new \DateTime();
        $this->time = is_null($time) ? $now->format("Y-m-d H:i:s") : $time;
    }
    public function getAuthor()
    {
        return $this->author;
    }

    public function setAuthor($author)
    {
        $this->author = $author;
        return $this;
    }

    public function getContent()
    {
        return $this->content;
    }

    public function setContent($content)
    {
        $this->content = $content;
        return $this;
    }

    public function getTime()
    {
        return $this->time;
    }

}