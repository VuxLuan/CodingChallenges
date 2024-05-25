Build My Own wc Tool

This challenge is to build my own version of the Unix command line tool wc!

Compile the C# code into an executable using the .NET Core SDK:

dotnet build -o ./build

Once compiled, you can use the ccwc tool from the command line by providing the appropriate options and filename. Here are some examples:

./build/ccwc -c test.txt
./build/ccwc -l test.txt
./build/ccwc -w test.txt
./build/ccwc -m test.txt
./build/ccwc test.txt
cat test.txt | ./build/ccwc -l
