<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1" />
    M: <input type="text" name="num2" />
    <input type="submit" />
</form>

<ul>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2']))
    {
        $list = $_GET['num1'];
        $element = $_GET['num2'];

        for ($i = 1; $i <= $list; $i++)
        {
            echo "<li>List $i";
            echo '<ul>';

            for ($j = 1; $j <= $element; $j++)
            {
                echo "<li>Element $i.$j</li>";
            }
            echo '</ul>';
            echo "</li>";
        }
    }
    ?>
</ul>

</body>
</html>