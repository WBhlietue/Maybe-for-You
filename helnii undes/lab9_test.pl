print("temperature: ");
$temperature = <stdin>;
if($temperature > 40){
    print("haluun baina");
}elsif($temperature < 0){
    print("huiten baina");
}else{
    print("heviin");
}
print("\n");


print("debug: ");
$debug = <stdin>;
print("eureg too") if($debug > 0);
print("\n");

print("year: ");
$year = <stdin>;
print("Z uyiihen") unless ($year < 2000);
print("\n");