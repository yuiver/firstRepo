using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //문제 1 프로그램 사용자로부터 양의 정수 하나 입력받아서, 그 수만큼 "Hello world!"을 출력하는 프로그램 작성.
            //    ex) User input -> 1
            //           "Hello world"

            Console.WriteLine("양의 정수를 입력하시오. : "); //사용자에게 지시사항을 텍스트로 출력한다.
            int Poi = Convert.ToInt32(Console.ReadLine()); //정수를 선언하며 문자를 정수로 전환하여 입력받는다.
            while (Poi > 0) //정수Poi가 0보다 값이 크다면 루프한다.
            {
                Console.WriteLine("Hello World");//문제의 내용인 "Hello world"텍스트를 출력한다.
                Poi -= 1; //루프가 끝나는 조건을 달성하기 위해 루프할때마다 정수 poi가 루프할때마다 1씩 줄어든다.
            }   //while




            //문제2 프로그램 사용자로부터 양의 정수를 하나 입력 받은 다음, 그 수만큼 3의 배수를 출력하는 프로그램 작성.
            //    ex) User input -> 5
            //            "3,6,9,12,15"



            const int THREEM = 3; //3의 배수를 출력하기위해 상수 3 선언 및 초기화
            int loop3 = 1; // 정수를 곱하는것이기 때문에 곱할 정수에 1을 넣고 선언 및 초기화


            Console.Write("\n\n양의 정수를 입력하시오. : "); //사용자에게 정수를 입력하라는 지시사항을 출력한다.
            int loopCounterEx2 = Convert.ToInt32(Console.ReadLine()); //곱할횟수를 정수를 선언하며 문자를 입력받고 정수로 변환합니다.

            while (loopCounterEx2 > 0) //정수loopCounterEx2가 0보다 값이 크다면 루프한다.
            {
                Console.Write("{0} ", THREEM * loop3); //상수THREEM과 정수loopCounterEx2를 곱한 값을 {0}안에 넣어 텍스트를 출력한다..
                loop3++; //3배의 배수를 표현하기 위해 올리기 위해 후위증가 연산자를 사용해 루프할때마다  정수loop3에 1을 더한다.
                loopCounterEx2--; //루프가 끝나는 조건을 달성하기 위해 후위 감소연산자를 사용해 루프할때마다 정수 loopCounterEx2이 루프할때마다 1씩 줄어든다.
            }   //while



            //문제3 프로그램 사용자로부터 계속해서 정수를 입력 받는다. 그리고 그 값을 계속해서 더해나간다. 이러한 작업은
            //   프로그램 사용자가 0을 입력할 때까지 계속되어야 하며, 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            //    ex) User input -> 1
            //        User input -> 0
            //        "모든 정수의 합: 1"


            int userInput3count = 0; //사용자가 입력한 값이 0인지 확인하기 위한 정수변수를 선언 및 초기화
            int userInput3Add = 0; //사용자가 입력한 정수의 값을 계산할 정수변수를 선언 및 초기화

            Console.Write("\n\n정수를 입력하세요.(0입력시 종료) : "); //줄 정리를 위해 이스케이프 시퀀스\n를 사용,사용자에게 지시사항을 전달하기위해 텍스트를 출력한다.
            int userInputval = Convert.ToInt32(Console.ReadLine()); //사용자가 입력한 정수를 선언하며 문자를 입력받고 정수로 변환한다.

            userInput3count += userInputval; //사용자가 입력한 값을 0인지 확인하기 위한 변수에 더한다.
            userInput3Add += userInputval; //사용자가 입력한 값을 모두 더하기 위해 정수의 합을 더하기 위한 변수에 더한다.

            while (userInput3count > 0) //사용자가 입력한 값이 들어가 있는 정수가 0보다 크다면 루프한다.
            {
                Console.Write("정수를 입력하세요.(0입력시 종료) : "); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
                int userInputva2 = Convert.ToInt32(Console.ReadLine()); //루프안에 사용자가 다시 정수를 입력할 변수를 선언하고 문자를 입력받아 정수로 변환한다.

                userInput3Add += userInputva2; //사용자가 입력한 값을 모두 더하기 위해 정수의 합을 더하기 위한 변수에 더한다.
                userInput3count = userInputva2; //사용자가 입력한 값을 0인지 확인하는 변수와 같게만들어 루프 종료조건을 만든다.
            }   //while
            Console.WriteLine("모든 정수의 합: {0}", userInput3Add); //사용자가 입력한 모든 정수의 합을 텍스트로 {0}안에 넣어 출력한다.


            //문제4 프로그램 사용자로부터 입력받은 숫자에 해당하는 구구단을 출력하되, 역순으로 출력하는 프로그램을 작성.

            Console.Write("구구단 중에서 출력하고 싶은 단 입력: "); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
            int usergugudan = Convert.ToInt32(Console.ReadLine()); //해당 구구단 단수를 출력하기위해 사용자로부터 숫자를 입력받기 위해 문자를 입력받아 정수로 변환한다.

            const int GUGU_LOOP_COUNT = 9; //구구단은 9단까지 있으니 상수로 사용자입력값 * 상수9 까지만 출력하기 위해 상수를 선언한다.
            int guguLoop = 1; //구구단을 출력하기 위해 정수변수를 선언 및 초기화
            int gugumul = 9; //역순으로 출력하기 위해 정수변수를 선언 및 초기화

            while (guguLoop <= GUGU_LOOP_COUNT) //상수 GUGU_LOOP_COUNT이 정수guguLoop보다 값이 크거나 같다면 루프한다.
            {
                Console.WriteLine("{0}*{1}={2}", usergugudan, gugumul, usergugudan * gugumul); //사용자에게 입력받은 정수는 {0}에 역순으로 출력하기위한 정수는 {1}에 그둘을 곱한 수는 {2}에 출력해서 구구단을 텍스로 출력한다.
                guguLoop++; //앞에 선언한 정수에 1씩 더해서 루프종료 조건을 만들기 위해 후위 증가연산자를 사용한다.
                gugumul--; //9번 반복되는 동안 9에서 1씩 빠지게 만들어 출력되는 텍스트가 구구단을 역순으로 출력하게 만드는 후위 감소연산자를 사용한다.
            }   // loop: 9번 도는 루프

            //문제5 프로그램 사용자로부터 입력받은 정수의 평균을 출력하는 프로그램을 작성하되,다음 두가지의 조건을 만족할 것.
            //    - 먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 그리고 그 수만큼 정수를 입력받는다.
            //    - 평균 값은 소수점이하((float) 넣자)까지 출력한다.
            //    ex) User input -> 10
            //        User input -> 10
            //        User input -> 10
            //        "평균값:0.0000"

            int userInput5Avg = 0; //사용자가 입력한 값를 더하기 위한 정수를 선언 및 초기화
            int userInput5Div = 0; //사용자가 입력한 횟수를 구하기 위한 정수를 선언 및 초기화
            float average = 0.0f; //평균값을 소수점이하로 출력하기 위한 실수를 선언 및 초기화

            Console.Write("\n\n몇개의 정수의 평균을 구할지 입력하세요. : "); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
            int userInput5 = Convert.ToInt32(Console.ReadLine()); //사용자가 입력할 횟수를 선언하며 문자로 입력받고 정수로 변환한다.

            while (userInput5 > 0) //사용자가 입력한 값 userInput5가 0보다 크다면 루프한다.
            {
                Console.Write("정수를 입력하세요. : "); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
                int userInput5Avginput = Convert.ToInt32(Console.ReadLine()); //루프안에 사용자가 입력한 문자를 입력받아 정수로 변환한다.

                userInput5Avg += userInput5Avginput; //사용자가 입력한 값을 더한다.
                userInput5--; //루프종료 조건을 만들기 위해 사용자가 몇개의 정수의 평균을 구할지 입력한 값을 후위 감소연산자를 사용해서 1씩 빼준다.
                userInput5Div++; //정수의 평균을 구하기 위해 루프할때마다 사용자가 입력한 값을 후위 증가연산자를 사용해서 1씩 더해준다.(정리하면서 보니 없어도 상관 없을거 같다.그냥 입력한 값을 나눠도 같은 결과가 나온다...)
            }   //while
            average = (float)userInput5Avg / userInput5Div; // 실수average에 소수점이하까지 평균값을 출력하기 위해 정수userInput5Avg를 실수로 변환해서 사용자가 입력한 횟수를 나누어 준다.
            Console.WriteLine("입력한 모든 정수의 평균: {0}", average); //average의 값을 {0}에 대입해서 텍스트로 출력한다.

            if (0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 == 1.0) //0.1을 10번 더한값이 1.0이라면(0.1을 10번 더한 값이 1.0인지 이대연 강사님이  부동소수점 에러와 앱실론에 대해서 알려주시기 위한 예제를 주셧다.)
            {
                Console.WriteLine("10번 더한 0.1은 1과 같다."); //if문의 값이 참이라면 해당 텍스트를 출력한다.
            }   //if
            else
            {
                Console.WriteLine("10번 더한 0.1은 1과 다르다?"); //if문의 값이 참이 아닌 나머지라면 해당 텍스트를 출력한다.
            }   //else

            //두 실수를 입력 받아서 값이 같은지 다른지 출력하는 프로그램 작성 (Equals 등 메서드 사용 X) / 위에 예제의 연장으로 알려주셧는데 오버로딩되서 참이라고 나온다.

            float fNum1 = 0.0f; // 실수1를 선언 및 초기화
            float fNum2 = 0.0f; // 실수2를 선언 및 초기화
            Console.WriteLine("첫번째 실수를 입력하세요."); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
            fNum1 = Convert.ToSingle(Console.ReadLine()); //사용자가 입력한 문자를 입력받아 실수로 변환한다.
            Console.WriteLine("두번째 실수를 입력하세요."); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
            fNum2 = Convert.ToSingle(Console.ReadLine()); //사용자가 입력한 문자를 입력받아 실수로 변환한다.

            if (fNum1 == fNum2) //실수 fNum1와 fNum2의 값이 같다면
            {
                Console.WriteLine("첫번째 실수와 두번째 실수는 같습니다."); //텍스트를 출력한다.
            }   //if
            else //if의 ()이 참이 아닌 나머지라면
            {
                Console.WriteLine("첫번째 실수와 두번째 실수는 다릅니다."); //텍스트를 출력한다.
            }   //else

            /**
             * LAB 문제 1
             * 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * (대,소문자 모두 카운트)
             *      ex)
             *              a
             *              b
             *              c
             *              d
             *              e
             *              Z
             *              #
             *              모음:2개
             *              자음:3개
             */
            //푸는걸 실패해서 예제 처리 해놨습니다.
            /*
            int consonantCount = 0;
            int vowelsCount = 0;
            int endKey = 0;
            char arpabetcount = '#';


            while (arpabetcount != '!')
            {
                Console.WriteLine("알파벳을 입력하세요,!를 입력하면 종료됩니다."); //사용자에게 지시사항을 전달하는 텍스트를 출력한다.
                char arpabet = Convert.ToChar(Console.ReadLine());

                switch (arpabet)
                {
                    case 'a':
                        vowelsCount++;
                        break;
                    case 'A':
                        vowelsCount++;
                        break;
                    case 'e':
                        vowelsCount++;
                        break;
                    case 'E':
                        vowelsCount++;
                        break;
                    case 'i':
                        vowelsCount++;
                        break;
                    case 'I':
                        vowelsCount++;
                        break;
                    case 'o':
                        vowelsCount++;
                        break;
                    case 'O':
                        vowelsCount++;
                        break;
                    case 'u':
                        vowelsCount++;
                        break;
                    case 'U':
                        vowelsCount++;
                        break;
                    default:
                        consonantCount++;
                        break;
                }       // switch: 알파벳 갯수 세는 스위치

            } //while

            Console.WriteLine("사용자가 입력한 자음의 개수는 {0}개입니다.", consonantCount);
            Console.WriteLine("사용자가 입력한 모음의 개수는 {0}개입니다.", vowelsCount);
            */





            /* LAB 문제2
            * 숫자 맞추기 게임
            * 숫자 알아맞히기 게임이다. 프로그램은 1~100 사이의 정수를 저장하고 있음. 사용자는 질문을 통해서
            * 숫자를 알아 맞힌다. 사용자가 답을 제시하면 프로그램은 제시된 정수가 더 낮은 값인지,높은 값인지 
            * 알려준다. 사용자가 알아맞힐 때까지 루프한다.(기본형)
            * 
            * - 프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에 사용자가 결정한 번호를
            *      컴퓨터가 추측하도록 수정한다. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를 컴퓨터에 알려야한다
            *      물론 이거도 컴퓨터가 맞힐때 까지 반복. (어려운거 1)
            * - 사용자가 결정한 값의 범위는 1~100인데 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수
            *      있도록 어려운거 1을 수정하시오.(어려운거 2)
            */


            Random randomLab2 = new Random(); //숫자를 맞추기 위한 랜덤변수를 선언

            int computer = randomLab2.Next(100) + 1; //0이 나오는걸 방지하기 위해 컴퓨터가 정한 랜덤값은 0이상100미만 + 1

            int answer = 0; //값을 입력하기 위한 변수를 선언 및 초기화

            while (computer > 0) //컴퓨터가 정한값이 0보다 크다면 루프

            {

                Console.WriteLine("1에서 100사이의 수를 입력하세요."); //지시사항을 텍스트로 출력

                answer = int.Parse(Console.ReadLine());

                if (answer == computer) //내가 입력한 값이 컴퓨터가 정한 랜덤값과 같다면

                {

                    Console.WriteLine("축하합니다. 정답입니다."); //텍스트를 출력

                    break; //루프종료
                }   //if


                if (answer > computer) //컴퓨터가 정한 랜덤값보다 내가 입력한 값이 작다면

                {

                    Console.WriteLine("더 작습니다."); //텍스트를 출력

                }   //if

                else //그 이외라면

                {

                    Console.WriteLine("더 큽니다."); //텍스트를 출력

                }   //else

            }   //while

            Random random = new Random(); //숫자를 맞추기 위한 랜덤변수를 선언

            Console.Write("1부터 100사이 중 당신이 생각한 숫자를 맞추겠습니다. 생각하시는 숫자를 입력해주세요."); //지시사항을 텍스트로 출력
            int answerLab3 = Convert.ToInt32(Console.ReadLine()); //사용자가 입력한 텍스트를 정수로 전환하여 입력 받음
            int min = 1; //최저값은 1
            int max = 100; //최대값은 100
            int computerAnswer = 50; //컴퓨터가 추측할 숫자의 시작을 50을 넣는게 가장 확률이 높아진다고 생각해서 두 숫자 사이의 중간값인 50을 입력했습니다.

            while (100 > 0) //무조건 루프 시키기 위해 무조건 참인 루프를 만들었습니다.

            {

                if (computerAnswer == answerLab3) //컴퓨터가 입력한 값이 내가 입력한 값과 같다면

                {

                    Console.WriteLine("정답은 {0}입니다. 컴퓨터가 제가 생각한 답을 맞췄습니다.", computerAnswer); //내가 입력한 값을 {0}에 넣어서 텍스트로 출력

                    break; //루프종료
                }   //if


                if (computerAnswer > answerLab3) //컴퓨터가 입력한 값이 내가 입력한 값보다 크다면

                {

                    Console.WriteLine("{0}보다 작습니다", computerAnswer); //컴퓨터가 입력한 값을 {0}에 넣어 텍스트를 출력
                    max = computerAnswer; //랜덤의 최대값을 컴퓨터가 입력한 값으로 초기화
                    computerAnswer = random.Next(min, max); //컴퓨터가 입력할 다음 값을 이상미만의 랜덤으로 초기화


                }   //if

                if (computerAnswer < answerLab3) //컴퓨터가 입력한 값이 내가 입력한 값보다 작다면

                {

                    Console.WriteLine("{0}보다 큽니다.", computerAnswer); //컴퓨터가 입력한 값을 {0}에 넣어 텍스트를 출력
                    min = computerAnswer + 1; //랜덤의 최소값을 컴퓨터가 입력한 값으로 초기화 (이상 미만이라 max에 +1을 넣어야할거같은데 비정상적으로 같은 값을 반복해서 min에 +1을 넣었는데 이것은 질문 드리고 싶습니다.)
                    computerAnswer = random.Next(min, max); //컴퓨터가 입력할 다음 값을 이상미만의 랜덤으로 초기화
                }   //if



            }   //while


            /**
             * 산수 문제 자동 출제
             * 산수 문제를 자동으로 출제하는 프로그램을 작성해보자. 덧셈 문제를 자동으로 생성하여야 한다.
             * 피연산자는 0~99 사이의 숫자 (난수) 한번이라도 맞으면 종료. 틀리면 리트라이
             * 
             * -뺄셈 곱셈 나눗셈 문제도 출제 
             */


            int answer1 = 0; //answer1 이라는 정수를 입력값을 선언 및 초기화 하기위해 입력
            Random randomQ = new Random(); //난수를 만들기 위한 랜덤변수를 선언
            int q1 = randomQ.Next(100); //피연산자 0이상 100미만의 랜덤값을 정수 q1으로 만듬
            int q2 = randomQ.Next(100); //피연산자 0이상 100미만의 랜덤값을 정수 q1으로 만듬
            int qAnswer = q1 + q2; //문제의 정답을 if문의 조건으로 만들기 위해 q1과 q2를 더한값이 qAnswer이라고 선언 및 초기화

            while (100 > 0) //루프시키기 위해 무조건 참인 값을 넣었음

            {

                Console.WriteLine("{0} + {1} = ", q1, q2); //랜덤값 q1 q2를 {0},{1}에 넣어 문제를 출력
                Console.Write(" 정답을 입력하세요"); //지시사항을 텍스트로 출력
                answer1 = Convert.ToInt32(Console.ReadLine()); //문제의 정답을 텍스트를 정수로 전환하여 입력 받음

                if (qAnswer == answer1) //문제의 답이 정답이라면 (if가 참이라면)

                {

                    Console.WriteLine("정답입니다. 수고하셧습니다."); //텍스트를 출력

                    break; //루프종료
                }   //if
                else //if가 참이 아닌 나머지라면 새로운 문제를 출제
                {
                    q1 = randomQ.Next(100); //랜덤값 초기화
                    q2 = randomQ.Next(100); //랜덤값 초기화
                    qAnswer = q1 + q2; //초기화한 값으로 if의 조건을 바꿈
                    Console.WriteLine("틀렸습니다. 다시 풀어보세요."); //텍스트를 출력
                }   //else


            }   //while





        }       //Main()
    }       //Class
}       //namespace