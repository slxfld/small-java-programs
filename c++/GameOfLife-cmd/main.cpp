#include <iostream>
#include <windows.h>
#include <unistd.h>
#define ar 32

bool current[ar][ar];
bool next[ar][ar];
int x, y, count;

void update()
{
	x = 2;
	y = 2;
	while (true)
	{
		count = 
			current[y - 1][x - 1]
		+ 	current[y + 0][x - 1]
		+ 	current[y + 1][x - 1]
			
		+ 	current[y - 1][x + 0]
		+ 	current[y + 1][x + 0]
			
		+ 	current[y - 1][x + 1]
		+ 	current[y + 0][x + 1]
		+ 	current[y + 1][x + 1];

		next[y][x] = (current[y][x] && count <  2);
		next[y][x] = (current[y][x] && count == 2 || current[y][x] == false && count == 3);
		next[y][x] = (count > 3);

        x++;
        if (x > ar)
		{
			x = 2;
			y++;
        }
        if (y > ar) break;
    }
}

void draw(DWORD & dw, HANDLE & hstd, COORD & here)
{
	for (int i = 2; i < ar; i++)
		for (int j = 2; j < ar; j++)
		{
			current[i][j] = next[i][j];
			here.X = j;
			here.Y = i;
			if (current[i][j] == true)
			{
				WriteConsoleOutputCharacter(hstd, "#", 1, here, & dw);
			}
			else
			{
				WriteConsoleOutputCharacter(hstd, " ", 1, here, & dw);
			}
	}
}

int main()
{
	DWORD dw;
	COORD here;
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
    
	if (hStdOut == INVALID_HANDLE_VALUE)
        printf("Invalid handle");
	
	/*array setup*/
	for (int i = 0; i < ar; i++)
		for (int j = 0; j < ar; j++)
		{
			current[i][j] = false;
			next[i][j] = false;
		}
	
	/* make a blinker */
	next[15][15] = true;
	next[15][16] = true;
	next[15][14] = true;
	
	system("cls");
	while (true)
	{
		update();
		draw(dw, hStdOut, here);
	}
	
	return 0;
}
