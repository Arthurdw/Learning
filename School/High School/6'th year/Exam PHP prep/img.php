<?php
function raise($message, $status)
{
    return die(json_encode(array("message" => $message, "status" => $status)));
}

$provided_size = isset($_GET['size']) ? $_GET['size'] : "300x200";

$color = isset($_GET['color']) ? $_GET['color'] : "ffffff";
$background = isset($_GET['background']) ? $_GET['background'] : "383838";
$size = explode("x", $provided_size);
$text = isset($_GET['text']) ? $_GET['text'] : $provided_size;

if (count($size) != 2) {
    raise("An invalid size was provided. (provided size: '$provided_size')", 400);
}

$img = array(
    "width" => (int) $size[0],
    "height" => (int) $size[1],
    "text" => $text
);

$background = explode(",", hex2rgb($background));
$color = explode(",", hex2rgb($color));

header("Content-Type: image/png");
$image = @imagecreate($img['width'], $img['height'])
    or raise("Could not create image!", 500);

$background_color = imagecolorallocate($image, $background[0], $background[1], $background[2]);
$text_color = imagecolorallocate($image, $color[0], $color[1], $color[2]);

imagestring(
    $image,
    10,
    $img["width"] / 2 - strlen($img["text"]) * 5,
    $img["height"] / 2 - 5,
    $img["text"],
    $text_color
);

imagepng($image);
imagedestroy($image);

function hex2rgb($hex) {
   $hex = str_replace("#", "", $hex);

   switch (strlen($hex)) {
       case 1:
           $hex = $hex.$hex;
       case 2:
          $r = hexdec($hex);
          $g = hexdec($hex);
          $b = hexdec($hex);
           break;

       case 3:
          $r = hexdec(substr($hex,0,1).substr($hex,0,1));
          $g = hexdec(substr($hex,1,1).substr($hex,1,1));
          $b = hexdec(substr($hex,2,1).substr($hex,2,1));
           break;

       default:
          $r = hexdec(substr($hex,0,2));
          $g = hexdec(substr($hex,2,2));
          $b = hexdec(substr($hex,4,2));
           break;
   }

   $rgb = array($r, $g, $b);
   return implode(",", $rgb);
}
