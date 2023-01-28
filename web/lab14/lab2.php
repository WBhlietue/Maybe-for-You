<html>

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<style>
  table,
  th,
  td {
    border: 1px solid purple;
  }

  img {
    display: block;
    margin-left: auto;
    margin-right: auto;
  }

  table.center {
    margin-left: auto;
    margin-right: auto;
  }

  .myDiv {
    border: 5px outset purple;
    background-color: lightblue;
    text-align: center;
  }

  h2 {
    text-align: center;
  }

  h3 {
    text-align: center;
  }

  p {
    text-align: center;
  }

  dt {
    text-align: center;
  }

  dd {
    text-align: center;
  }

  .container {
    position: relative;
    font-family: Arial;
  }

  .text-block {
    position: center;
    bottom: 20px;
    right: 20px;
    background-color: lightblue;
    color: purple;
    padding-left: 20px;
    padding-right: 20px;
  }

  div.container {
    text-align: center;
  }

  ul.myUL {
    display: inline-block;
    text-align: left;
  }
</style>

<body>

  <div class="myDiv">
    <h2>
      Миний танилцуулга
    </h2>

  </div>
  <h3>
    Намайг <?php echo $_GET["ner"] ?> гэдэг. Би
    <?php
    $year = substr($_GET["birthday"], 0, 4);
    $age = ((int)date("Y") - (int)$year);
    if ((int)substr($_GET["birthday"], 5, 2) > date("M"))
    {
      $age--;
    }
    else if ((int)substr($_GET["birthday"], 5, 2) == date("M"))
    {
      if ((int)substr($_GET["birthday"], 7, 2) > date("D"))
      {
        $age--;
      }
    }
    echo $age;
    ?> настай ШУТИС МХТС-ын <?php echo $_GET["quantity"]?>-р курсийн оюутан. Ирээдүйд өгөдлийн инженер мэргэжилтэй болно.

  </h3>
  <span style="width: 20px; height:20px; margin-left:100px;background-color:<?php echo $_GET["myColor"]?>; float:left"></span>	&nbsp;	&nbsp;Бол миний дуртай өнгө 
  <p>Хүйс: <?php echo $_GET["gender"] ?></p>
  <p>Миний харъяалал: <?php echo $_GET["citizen"]?></p>
  <p>Миний мэйл хаяг: <?php echo $_GET["email"] ?></p>
  <p>Миний төрсөн өдөр: <?php echo $_GET["birthday"] ?></p>
  <p>Намайг 1 өгүүлбэрээр илэрхийлвэл: <?php echo $_GET["text"] ?></p>
  <h3>Миний гадаад төрх</h3>
  <p>Би <span style="color:black;font-weight:bold">хар</span> үстэй бөгөөд миний нүдний өнгө <span style="color: brown ;font-weight:bold">бор</span> , мөн цайвар арьстай.</p>
  <div class="container">
    <img src="profile.jpg" , max-width="300" , height=auto>
    <div class="text-block">
      <a href="https://www.facebook.com/munkh.ujin.5/" target="_blank">Visit my facebook!</a>
    </div>
  </div>
  <p>
  

  </p>
  <table style="width:10%" class="center">
    <tr>
      <th>Өндөр</th>
      <th>Жин</th>
    </tr>
    <tr>
      <td>162см</td>
      <td>50кг</td>

    </tr>

  </table>
  <p>

  </p>
  <table class="center">
    <tr>
      <th> Дуртай зүйлс</th>

    </tr>
    <tr>
      <td>Өнгө</td>
      <td>Хар</td>
    </tr>
    <tr>
      <td>Тоо</td>
      <td>17</td>
    </tr>
    <tr>
      <td>Хоол</td>
      <td>Бүх хоол</td>
    </tr>
  </table>
  <h3>
    Эдгээр нь миний зан чанарууд
  </h3>
  <table class="center">
    <tr>
      <td>Өөрийнхөөрөө</td>
      <td>Хичээнгүй</td>
    </tr>
    <tr>
      <td>Хөгжилтэй</td>
      <td>Хянамгай</td>
    </tr>
  </table>
  <div class="container">
    <h3>Чөлөөт цагаараа хийдэг зүйлс</h3>

    <ul class="myUL">
      <li>Хөгжим сонсох</li>
      <li>Ном унших</li>
      <li>Кино үзэх</li>
      <li>Код бичих</li>
    </ul>
  </div>
  <h3> Миний унших дуртай номнууд</h3>
  <p> <i> "Хэтэрхий олон катеринууд"</i><br> <i>"Софийн ертөнц</i></p>


  <h3>Би <u>амьтан</u> тэжээх дуртай</h3>

  <p>Миний тэжээдэг амьтад болон тэдний товч танилцуулга:</p>

  <dl>
    <dt>Rex</dt>
    <dd>Тэр бол миний нохой, <sub>хавчаарк</sub> нохой бөгөөд их ухаалаг.</dd>
    <dt>Marry</dt>
    <dd>Тэр мөн нохой, <sup>монгол банхар </sup>бөгөөд сэгсгэр үстнй учраас их эгдүүтэй.</dd>
  </dl>
  <h3>
    Би энэ улирал 18 кредит хичээл үзэж байгаа. Доорх зурагт миний хичээлийн хуваарь харагдаж байна.
  </h3>
  <img src="timetable.jpg" , width="600" , height="300">
  <h3>Мэрэгжлийнхээ талаар бага зэрэг тайлбар хүргэе.</h3>

  <p>Data Analyst, Data Scientist буюу Монголоор өгөгдлийн шинжээч, өгөгдлийн шинжлэх ухаанч мэргэжил нь зөвхөн Монгол улсад гэлтгүй дэлхий дахинд 21-р зуунд хамгийн их эрэлттэй мэргэжлийн нэгт тооцогдож байна. Хэдийгээр 20-н жил ч хүрэхгүй түүхтэй мэргэжил боловч 2012 онд Харвардын Их Сургууль “the sexiest job of the 21st century” хэмээн нэрлэснээс хойш байгууллага болгонд заавал дата аналист байх ёстой юм байна гэдгийг бүгд ойлгоод байна.</p>

  <hr>

  <p>21-р зуунд дэлхий ертөнц дижиталчлагдаж, хаа сайгүй өгөгдөл мэдээллээр баяжиж эхэлсэн. Ямар ч төрлийн бизнес, байгууллагууд асар их тоо баримт, мэдээллийг цаг, минут, өдөр тутамд цуглуулж байдгийг бид мэднэ. Тэгэхлээр энэ их дата мэдээллийг эрэмбэлж, боловсруулж, ангилж, цэгцэлж, дүгнэж, шинжилж, түүнээс хэрэгтэй мэдээллээ шүүж аваад, бизнест ашигтай шийдвэр гаргахад туслах боломжийг өгөгдлийн шинжлэх ухаанчид бий болгодог.</p>

  <hr>

  <p>Хэдийгээр маш хялбар сонсогдож байгаа ч энэ шийдвэр нь ихэнхдээ бизнесийн удирдлагуудын зөн совин дээрээ суурилж гаргасан шийдвэрүүд байх нь элбэг бөгөөд алдаж онох нь бий. Тэгэхээр жижиг, дунд, том бизнесүүдийн хувьд цуглуулсан асар их дата дээр тулгуурлан хамгийн зөв, ашигтай шийдвэрүүдийг хамгийн бага зардлаар гаргахад туслах нь дата аналистуудын үүрэг болно.</p>
  <div class="myDiv">
    <h4>
      Миний танилцуулгатай танилцсанд баярлалаа.
    </h4>
    <p>
      <strong> Амжилт хүсье!</strong>

    </p>

  </div>

</body>

</html>