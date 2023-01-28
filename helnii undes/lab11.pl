use Time::HiRes;
$start = Time::HiRes::gettimeofday();

for($i = 0; $i < 10000; $i++){
    $n = int(rand(50000)) + 10000;
    push(@b, $n);
}
$sum1 = 0;
$sum2 = 0;
for $i (@b){
    if($i % 2 == 1){
        $sum1 += ($i * $i);
    }else{
        $sum2 += ($i / 2);
    }
}

print("songroin kv niilber = ", $sum1);
print("\ntegshiin hagsiin niilber = ", $sum2);

$end = Time::HiRes::gettimeofday();
print("\n\n", ($end - $start) * 1000);