<html>

<head>
    <tittle> lab3</tittle>
    <meta charset="UTF-16">
</head>

<body>
    <h3> My CV</h3>
    <?php
    $targetPage = "";
    $json = file_get_contents("php://input");
    if ($_SERVER["REQUEST_METHOD"] == "POST")
    {
        $targetPage = "lab2.php?" . $json;
    }
    ?>
    <form action="index.php" method="post">
        <table border="1" cellspacing"0" cellpadding="10">
            <tr>
                <th align="right">
                    <label for="ner"> Нэр: </label>
                </th>
                <td><input id="ner" type="text" name="ner"></td>
            </tr>
            <tr>
                <th align="right"><label> Хүйс: </label></th>
                <td> <label for="male"> Эрэгтэй </label>
                    <input id="male" type="radio" name="gender" value="Эрэгтэй" checked>
                    <label for="female"> Эмэгтэй</label>
                    <input id="female" type="radio" name="gender" value="Эмэгтэй">
                </td>
            </tr>
            <tr>
                <th align="right"><label> Харъяалал: </label></th>
                <td> <select name="citizen">
                        <option> Монгол </option>
                        <option> Орос</option>
                        <option> Хятад </option>

                    </select>
                </td>
            </tr>
            <tr>
                <th align="right"> <label> Мэддэг хэл:</label></th>
                <td><input type="checkbox" id="language1" name="language1" value="english">
                    <label for="vehicle1"> Англи</label><br>
                    <input type="checkbox" id="language2" name="language2" value="russia">
                    <label for="language2"> Орос</label><br>
                    <input type="checkbox" id="language3" name="language3" value="china">
                    <label for="language3"> Хятад</label><br>
                    <input type="checkbox" id="language4" name="language4" value="korea">
                    <label for="language4"> Солонгос</label><br>
                    <input type="checkbox" id="language5" name="language5" value="korea">
                    <label for="language5"> Япон</label><br>
                    <input type="checkbox" id="language6" name="language6" value="germany">
                    <label for="language6"> Герман</label><br>
                </td>

            </tr>
            <tr>
                <th align="right"><label for="quantity">Хэрвээ та оюутан бол курс ээ оруулна уу?:</label></th>
                <td><input type="number" id="quantity" name="quantity" min="1" max="7"></td>
            </tr>
            <tr>
                <th align="right"><label for="birthday">Төрсөн он сар:</label></th>
                <th> <input type="date" id="birthday" name="birthday">

                </th>
            </tr>
            <tr>
                <th align="right"><label for="email">Мэйл хаягаа оруулна уу:</label></th>
                <td><input type="email" id="email" name="email"></td>
            </tr>
            <tr>
                <th align="right">
                    <label for="myColor"> Дуртай өнгө:</label>
                </th>
                <td> <input id="myColor" type="color" name="myColor" value="#FFFFFF"></td>
            </tr>
            <tr>
                <th align="right"> <label for="text"> Өөрийгөө нэг өгүүлбэрээр илэрхийлнэ үү:</label></th>
                <td> <textarea id="text" name="text" row="4" cols="30"> </textarea></td>
            </tr>
        </table>
        <iframe height="600" width="50%" title="myframe" src=<?php echo $targetPage ?>> </iframe>
        <button type="submit"> Илгээх</button>

    </form>

</body>

</html>