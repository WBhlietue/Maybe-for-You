<html>
   <head>
      <title>Hello World</title>
      <style>
         input{
            display: table-cell;
            margin: 10px;
         }
         label{
            display: table-cell;
         }
         form{
            display: table;
         }
         p{
            display: table-row;
         }
         td{
            height: 30px;
            width: 100px;
            text-align: center;
         }
         .f{
            /* height: 10px; */
            /* padding: -10px; */
            margin: -10px;
            position: relative;
            left: 30px;
            top: 10px;
         }
         .u{
            /* border: 1px solid black; */
            height: 400px;
            width: 400px;
            position: absolute;
            right: 100px;
            top: 100px;
         }
         
      </style>
   </head>
   
   <body>
      <form  th:action = "@{/location}" th:object = "${location}" method="post">
         <input type="hidden" name="val" value="test">
         <input type="hidden" name="pro" value="add">
         <p>
            <label>ID</label>
            <input name = "id" type="number">
         </p>
         <p>
            <label>Code</label>
            <input name = "lcode" type="text">
         </p>
         <p>
            <label>Name</label>
            <input name = "lname" type="text">
         </p>
         <p>
            <label>Type</label>
            <p><input name = "itype" type="radio"  value="Urban" checked> <label>Urban</label></p>
            <p><input name = "itype" type="radio"  value="Rural"> <label>Rural</label></p>
         </p>
         <input type="submit" value="Save">
      </form>
      <h3 >
         <table border="1px">
            ${value}
         </table>
      </h3>
      <div class="u">
         ${update}
      </div>
      
   </body>

</html>