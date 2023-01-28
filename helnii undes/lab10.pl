print("input massiv item's number n = ");
$n = <stdin>;
for($i = 0; $i <= $n; $i++)
{
    print("b[", $i, "] = ");
    $t = <stdin>;
    push(@b, $t);
}
$p = 1;
for $num (@b){
    $p *= $num;
}
print("entuudiing urjver = ", $p);