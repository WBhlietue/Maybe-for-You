$str = <stdin>;
open $fileIn, ">", "./content.txt";
print $fileIn $str;
close $fileIn;

open $fileOut, "<", "./content.txt" ;
@datas = <$fileOut>;
close $fileOut;
print @datas;