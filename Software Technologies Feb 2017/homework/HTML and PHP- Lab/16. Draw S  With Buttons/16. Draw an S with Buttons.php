<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

    <style type = "text/css">
        .blueButtons
        {
            background-color: blue;
        }
    </style>

</head>
<body>
<?php
for($y = 0; $y < 9; $y++)
{
    for ($x = 0; $x < 5; $x++)
    {
        if($y == 0 || $y == 4 || $y == 8)
        {
            echo "<button class = blueButtons>1</button>";
        }
        else if($y > 0 && $y < 4 && $x == 0)
        {
            echo "<button class = blueButtons>1</button>";
        }
        else if($y > 4 && $y < 8 && $x == 4)
        {
            echo "<button class = blueButtons>1</button>";
        }
        else
        {
            echo "<button>0</button>";
        }
    }
    echo "</br>";
}
?>
</body>
</html>