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
                $result = 1;
                for($i = 2; $i <= $_GET['num']; $i++)
                {
                    $result = $result * $i;
                }
                echo $result;
        }
    ?>
</body>
</html>