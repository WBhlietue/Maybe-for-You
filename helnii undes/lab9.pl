# 1. undur jil
# 2. garaas shalgaltini onoo ugj usgen unelgee
# 3. mashinii dugaar yvahgui udur


print("year: ");
$year = <stdin>;
if($year % 4 == 0){
    print("undur jil mun");
}else{
    print("undur jil bish");
}
print("\n\n");

print("score: ");
$score = <stdin>;
if($score > 100 || $score < 0){
    print("Zuw dun oruul");
}else{
    if($score >= 90){
        print("A");
    }elsif($score >= 80){
        print("B");
    }elsif($score >= 70){
        print("C");
    }elsif($score >= 60){
        print("D");
    }else{
        print("F");
    }
}
print("\n\n");


print("mashinii dugaariin 4n too: ");
$dugaar = <stdin>;
$lastNum = $dugaar % 5;
if($lastNum == 0){
    print("baasan yvahgui");
}elsif($lastNum == 1){
    print("davaa yvahgui");
}elsif($lastNum == 2){
    print("mygmar yvahgui");
}elsif($lastNum == 3){
    print("lhagva yvahgui");
}else{
    print("purev yvahgui");
}
