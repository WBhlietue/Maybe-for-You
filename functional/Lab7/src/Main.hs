-- where
-- let
-- do
-- case of

letFunc n1 n2 n3 = let 
            a = n1
            b = n2
            c = n3
          in do
            print("x1 = " ++ show ((-b + (b*b - 4 * a * c)**0.5)/2))
            print("x2 = " ++ show ((-b - (b*b - 4 * a * c)**0.5)/2))
            
whereFunc n1 n2 = print("c = " ++ (show ((a*a + b*b) ** 0.5)))
          where 
                a = n1
                b = n2
caseFunc n1 = case n1 of
                  1->print("Monday")
                  2->print("Tuesday")
                  3->print("Wednesday")
                  4->print("Thursday")
                  5->print("Friday")
                  6->print("Saturday")
                  7->print("Sunday")

main = do
  letFunc 1 5 6
  whereFunc 3 4
  caseFunc 4