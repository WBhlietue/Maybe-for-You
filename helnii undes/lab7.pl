print "Hello World!\n\n";

@people = ("Alice ", "Alex ", "Albert ");
@guys = @people[1..2];
print "Peoples: ", @guys, "\n\n";

$tax = 250;
$subtitle = 2;
$answer = $subtitle * (1 + $tax / 100.0);
print $answer, "\n\n";

$value = 3;
$cube = $value ** 3;
print $cube, "\n\n\n";

#mashinii dugaar
$code = "УБИ5645";
$lastNum = substr($code, -1);
@days = ("Monday ", "Tuesday ", "Wednesday ", "Thursday ", "Friday ");
@alwaysMoveDay = ("Saturday ", "Sunday ");
$noMoveDay = $lastNum % 5 - 1;
delete @days[$noMoveDay];
print @days, @alwaysMoveDay, "\n\n\n";


# 1, 2, 3, 4, 5, 6 massiv
# 3 aas ih elementtei shine massiv

@nums = (1..6);
@answer = ();
for(@nums){
    if($_ > 3){
        push(@answer, $_);
    }
}

for(@answer){
    print $_, " ";
}