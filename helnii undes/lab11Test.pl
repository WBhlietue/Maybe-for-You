use Time::HiRes;
$a = Time::HiRes::gettimeofday();
for($i = 0; $i < 1000000; $i++){
    $i = $i + $i - $i;
}
$b = Time::HiRes::gettimeofday();
print(($b - $a) * 1000);