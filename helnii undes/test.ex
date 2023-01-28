defmodule Main do
  # loop функцийг дуудна.
  def startLoop(a) do
    loop(a, a)
  end

  # a-г 1 болтол өөрийгөө дууддаг реккурсив функц.
  #
  # Энэ реккурсивээр a нь 20-1 хүртэл байдаг ба divide функцийг
  # 1-20 хүртэл дарааллаар дуудахийн тулд (target - a + 1) гэдгийг ашиглана.
  def loop(a, target) do
    divide(true, target - a + 1, 0)

    if(a > 1) do
      loop(a - 1, target)
    end
  end

  # divide функцийн аргументууд:
  #   init - гаднаас болон өөрийгөө дуудсан эсэхийг ялгах
  #       Гаднаас дуудсан бол true, өөрийгбб дуудсан бол false утга авна.
  #       Хэрэв гаднаас дуудсан бол мөрний хамгийн эхэнд задлах гэж байгаа тоог хэвлэнэ.
  #   num - хуваах гэж байгаа тоо
  #   count - хуваагчийн тоо
  #   divd - хуваагч. default утга нь 2
  #
  # num тоог divd-д хуваагдахгүй болтол нь хувааж divd-ийг 1-ээр ихэсгэж дахин хуваана.
  # Хамгийн сүүлд хэдэн тоонд задалснийг хэвлэж гаргана.
  def divide(init, num, count, divd \\ 2) do
    if(init) do
      if(num != 1) do
        IO.puts("")
      end

      IO.write("#{num}: ")
    end

    if(num != 1) do
      if(rem(num, divd) == 0) do
        num = div(num, divd)

        if(count == 0) do
          IO.write(divd)
        else
          IO.write(", #{divd}")
        end

        divide(false, num, count + 1, divd)
      else
        divide(false, num, count, divd + 1)
      end
    else
      if(count == 0) do
        IO.write("null")
      end

      IO.puts("")
      IO.write("                               -> #{count}")
    end
  end
end

# а тоог гараас оруулж Main module-ийн
# startLoop функцийг а аргументтэй дуудна
{a, _} = IO.gets("input num: ") |> Integer.parse()
Main.startLoop(a)
