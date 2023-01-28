import Data.Char

fibbo 1 = do
  print("end, first value is 0 and return")
  return 0
fibbo 2 = do
  print("2nd value is 1")
  return 1

fibbo n = do
  print("now is " ++ show(n) ++ "th element")
  n1 <- fibbo(n-1)
  n2 <- fibbo(n-2)
  let num = n1+n2
  print(show(n) ++ "th element's value is " ++ show(num))
  return num

getNum = do
  print("enter the number")
  x <- getLine
  if(all(\d->isDigit d) x) then
    return (read x::Integer)
  else do
    print("this is not number!")
    getNum

main = do
  print("Fibonacci programm Start")
  num <- getNum
  fibbo (num) >>= \x -> print(x)
  print("Fibonacci programm End")
