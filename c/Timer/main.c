#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <time.h>
#include <ctype.h>
#include <stdbool.h>

int checkNULL(int num, char * arr[]) 
{
    if (arr[num] == NULL)
        return 0;

    return 1;
}

int main(int argc, char * argv[])
{
    int min = 0;
    int hour = 0;
    int sec = 0;
    int msec = 0;
    int trigger = 1000;

    /* parse args */
    for (int i = 1; i < argc; i++)
    {
        if (checkNULL(i + 1, argv))
        {
            if (strcmp(argv[i], "-h") == 0)
            {
                hour = atoi(argv[i + 1]);
            } 
            else if (strcmp(argv[i], "-m") == 0)
            {
                min = atoi(argv[i + 1]);
            } 
            else if (strcmp(argv[i], "-s") == 0)
            {
                sec = atoi(argv[i + 1]);
            }
        }
    }
    printf("\n");


    /* main loop */
    while (true) {
        clock_t bef = clock();
        do 
        {
            clock_t diff = clock() - bef;
            msec = diff * 1000 / CLOCKS_PER_SEC;
        } while (msec < trigger);

        sec--;

        if (sec == -1)
        {
            sec = 59;
            min--;
            if (min == -1) 
            {
                min = 59;
                hour--;
                if (hour == -1) 
                    break;
            }
        }


        /* output */
        if (hour < 10) 
        {
            printf("0%d:", hour);
        } 
        else 
        {
            printf("%d:", hour);
        }
        if (min < 10)
        {
            printf("0%d:", min);
        } 
        else
        {
            printf("%d:", min);
        }
        if (sec < 10)
        {
            printf("0%d", sec);
        } 
        else
        {
            printf("%d", sec);
        }
        printf("\n");
    }
    return 0;
}
