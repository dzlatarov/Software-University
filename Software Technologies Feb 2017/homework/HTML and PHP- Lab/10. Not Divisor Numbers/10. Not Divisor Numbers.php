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
            $k = intval($_GET['num']);

            for($i = $k; $i >= 1; $i--)
            {
                if($k % $i != 0)
                {
                    echo $i;
                    echo " ";
                }
            }
        }
    ?>
</body>
</html>