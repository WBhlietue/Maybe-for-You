module Main (main) where

f = 13
s = 20
startSpace = 20
line = "------------------------------------------------"

loop num = do
    if num == 0
        then putStr ""
    else do
        putStr " "
        loop (num-1)

node first second = do 
    loop startSpace
    putStrLn line
    loop startSpace
    putStr "|   "
    putStr first
    if (length first < f)
         then loop (f - (length first))
    else 
        putStr ""
    putStr "   |   "
    putStr second
    if (length second < s)
         then loop (s - (length second))
    else 
        putStr ""
    putStrLn "   |"

main = do
    node "Over:" "Tsogzol"
    node "Ner:" "Devjrekh"
    node "Nas:" "19"
    node "Huis:" "Er"
    node "Surguuli:" "Shutis-Mhts"
    node "Oyutnii kod:" "B210930007"
    node  "Angi:" "Medeelliin tehnology"
    loop startSpace
    putStrLn line
    