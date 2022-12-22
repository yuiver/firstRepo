using System;
using System.Runtime.InteropServices;

namespace ProjectBaseBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 9; //게임에서 부여할 시도횟수

            Random createRandomNumber = new Random(); //랜덤함수 선언
            int computerNumber1 = createRandomNumber.Next(1,10);  // 첫번째 난수 초기화 (확정)
            int computerNumber2 = createRandomNumber.Next(1,10); // 두번째 난수 선언 초기화(난수 선언은 무조건 루프 밖에서 해야한다.)
            //그렇다면 일회용 난수라면 루프안에서 하면 되겠다.

            while (1>0)
            {
                if (computerNumber2 != computerNumber1) { break; } //조건을 만족하면 두번째 난수가 확정되서 루프종료
                else
                {
                computerNumber2 = createRandomNumber.Next(1, 10);                    
                }
            } //두번째 난수를 고정하는 루프 (확정)

            int computerNumber3 = createRandomNumber.Next(1, 10); //세번째 난수 선언 초기화
            while (1>0) 
            {
                if (computerNumber3 != computerNumber1)
                {
                    if (computerNumber3 != computerNumber2) { break; } //두가지 조건을 만족하면 세번째 난수가 확정되서 루프종료
                }
                else 
                {
                    computerNumber3 = createRandomNumber.Next(1, 10);
                }
            } //세번째 난수를 고정하는 루프

            Console.WriteLine("게임 시작전에 심판에게 컴퓨터가 선택한 값을 알리겠습니다.\n선택한 값은 {0},{1},{2}순입니다.\n\n\n\n\n\n\n\n\n\n",
            computerNumber1,computerNumber2,computerNumber3); //3개의 난수가 중복되지 않고 잘 생성됬는지 확인하기 위해 확인차 출력


            while (tryCount > 0)
            {
                Console.WriteLine("남은 도전기회는 \"{0}\"회 입니다.",tryCount);
                int countOut = 0;
                int countStrike = 0;
                int countBall = 0;
                Console.Write("플레이어는 1~9안에서 첫 번째 숫자를 선택해주세요 : ");                
                int playerNumber1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("플레이어는 1~9안에서 두 번째 숫자를 선택해주세요 : ");
                int playerNumber2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("플레이어는 1~9안에서 세 번째 숫자를 선택해주세요 : ");
                int playerNumber3 = Convert.ToInt32(Console.ReadLine());
                if (playerNumber1 == computerNumber1)
                {
                    countStrike++;
                    if (playerNumber2 == computerNumber2)
                    {
                        countStrike++;
                        if (playerNumber3 == computerNumber3) { break; }
                        else
                        {
                            countOut++;
                        }
                    }
                    else if (playerNumber2 == computerNumber3)
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                    }
                    else 
                    {
                        countOut++;
                        if (playerNumber3 == computerNumber2) 
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber3) 
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }

                } //playerNumber1가 ture인 경우의 수
                else if (playerNumber1 == computerNumber2)
                {
                    countBall++;
                    if (playerNumber2 == computerNumber1)
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber3)
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else if (playerNumber2 == computerNumber3) 
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else
                    {
                        countOut++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber3)
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                } //palyerNumber1이 2인 경우의 수 
                else if (playerNumber1 == computerNumber3)
                {
                    countBall++;
                    if (playerNumber2 == computerNumber1)
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else if (playerNumber2 == computerNumber2)
                    {
                        countStrike++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else
                    {
                        countOut++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                } //playerNumber1이 3인 경우의 수
                else
                {
                    countOut++;
                    if (playerNumber2 == computerNumber1)
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber3)
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else if (playerNumber2 == computerNumber2)
                    {
                        countStrike++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber3)
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else if (playerNumber2 == computerNumber3)
                    {
                        countBall++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                    else
                    {
                        countOut++;
                        if (playerNumber3 == computerNumber1)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber2)
                        {
                            countBall++;
                        }
                        else if (playerNumber3 == computerNumber3)
                        {
                            countStrike++;
                        }
                        else
                        {
                            countOut++;
                        }
                    }
                } //다틀림
                //남은 횟수를 빼주고 선택지의 결과값을 알려주기 위해서 만듬
                Console.WriteLine("{0}스트라이크\t{1}볼\t{2}아웃", countStrike,countBall,countOut);
                tryCount--;
            }

                //남은 횟수가 0이 되기전에 빠져나왔다면 정답을 맞췄기 때문에 if와 else를 이용해 결과를 표기
            if (tryCount == 0)
            {
                Console.WriteLine("\n----------------------\n당신은 패배하셧습니다.\n----------------------\n");
            }
            else
            {
                Console.WriteLine("\n----------------------\n축하합니다. 당신은 승리하셧습니다.\n----------------------\n");
            }

            

            //대충 틀린건 없는데 종료할수있는 조건의 루프가 없다면 콘솔창이 출력되지 않는다.

        }
    }
}