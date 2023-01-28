$num = <stdin>;
@nums = (2 .. $num);
for(@nums)
{
    $count = 2;
    if($_ > 1){
        for($j = 2; $j  <= $_; $j++)
        {
            while($_ % $j == 0)
            {
                print($j, " ");
                $_ = $_ / $j;
            }
        }
    }
    print("\n");
}
