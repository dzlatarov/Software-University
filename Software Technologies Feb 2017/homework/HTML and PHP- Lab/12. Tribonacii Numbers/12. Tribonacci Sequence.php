<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if(isset($_GET['num']))
{
    $count = 1;
    $a = 1;
    $b = 0;
    $c = 0;

    for($i = 1; $i <= $_GET['num']; $i++)
    {
        if($count == 1)
        {
            $result = $a + $b + $c;
            $a = $a + $b + $c;

            $count = 2;
        }
        else if($count == 2)
        {
            $result = $a + $b + $c;
            $b = $a + $b + $c;

            $count = 3;
        }
        else
        {
            $result = $a + $b + $c;
            $c = $a + $b + $c;

            $count = 1;
        }

        echo $result;
        echo " ";
    }
}
?>
</body>
</html>