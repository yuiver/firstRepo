using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            * LAB 1.
            * 배열에서 최대값 찾기
            * 크기가 100인 배열을 1부터 100사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램 작성.
            * 
            * - 보기 좋게 출력(가독성 높아야함)
            * - 이상한 입력 예외처리
            * 
            */

            int[] lab1AssignmentArray = new int[100]; //1~100까지 넣을수있는 크기 100인 배열을 생성

            Random giveRandomLab1 = new Random(); //배열에 난수를 부여하기 위해서 랜덤변수를 생성

            for (int i = 0; i< lab1AssignmentArray.Length; i++) //for문을 사용해 배열의 크기만큼 루프해서
            {
                lab1AssignmentArray[i] = giveRandomLab1.Next(1,100); //0~99번까지 랜덤값을 부여
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t        생성된 난수는 이렇습니다.");
            Console.WriteLine("==========================================================================="); //가독성을 좋게하기 위해 꾸몄습니다.

            for (int i = 0; i < lab1AssignmentArray.Length; i+=10)  //
            {   //가독성 향상을 위해 난수마다 이스케이프 시퀀스 \t를 이용해 간격을 일정하게 벌리고 \n으로 줄간격을 벌리는 루프를 10개씩 정렬해서 배치했습니다.
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\n",
                lab1AssignmentArray[i], lab1AssignmentArray[i+1], lab1AssignmentArray[i+2], lab1AssignmentArray[i+3], lab1AssignmentArray[i+4], lab1AssignmentArray[i+5], lab1AssignmentArray[i+6], lab1AssignmentArray[i+7], lab1AssignmentArray[i+8], lab1AssignmentArray[i+9]);
            }   // if문을 이용해 if(i+1 % 10 == 0){\n}같은 방식을 사용할수도 있었는데 개인적으로 예쁘다고 생각하는쪽을 선택했는데 어느쪽이 더 프로그램적으로 가벼운지도 궁금합니다.
            int assignmentRandomMax = 0; // 최대값을 구하기 위한 인티저 변수

            for (int i = 0; i < lab1AssignmentArray.Length; i++) //모든 수를 비교하기 위해 배열 크기만큼 루프해서
            {
                if (assignmentRandomMax < lab1AssignmentArray[i]) //저장된 최대값보다 i번째 루프하는 배열속의 element가 더 크다면 실행되는 조건으로
                {
                    assignmentRandomMax = lab1AssignmentArray[i]; //i번째 요소를 최대값에 대입하는 방식으로 최대값을 전부 비교해서 찾는 방식을 사용했습니다.
                }
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t   그중 제일 큰 숫자는");
            Console.WriteLine("==========================================================================="); //가독성을 좋게하기 위해 꾸몄습니다.
            Console.WriteLine("\t\t\t\t   {0}", assignmentRandomMax); //마지막에는 최대값을 출력

            /**
             * LAB 2.
             * 사과를 제일 좋아하는 사람찾기
             * 사람들 5명 (사람1, 사람2, ..., 사람5)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
             * 데이터 입력이 마무리되면 누가 가장 많은 사과를 아침으로 먹었는지 출력한다.
             * 
             * - 이상한 입력 예외처리
             * - 제일 적게 먹은 사람도 찾도록 수정해보기(변형 1)
             * 
             * - 먹은 사과의 개수 순으로 정렬. 
             *   정렬 알고리즘은 본인이 사용가능한 것으로 하되. 형태는 아래와 같음.
             *   알고리즘을 잘 모르겠다면 버블 정렬을 도전해볼 것.(변형 2)
             *   
             * - 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것(변형 3) 
             *      - 정렬 도전 시 유저 입력 X
             *      - 데이터는 난수로 100~1000개 정도의 값
             *      - 중복 제거
             *      - 시간초는 전혀 상관 없음
             *      
             * - 본인의 능력껏 기본형, 변형 1, 변형 2, 여러운 거 난이도 순서로 도전해 볼 것.
             * 
             */

            //프로그램을 랜덤값을 대입하더라도 랜덤값을 부여하는 루프만 만들고 배열 숫자만 수정하면 작동하는 방식으로 만들었습니다. 


            int[] lab2AssignmentArray = new int[5]; //데이터를 입력할 학생의 명수를 []에서 수정해서 바꿀수 있도록
            int assignment2Max = 0; //최대값을 찾는 변수 생성
            int assignment2MaxP = 0; //최대값을 입력한 사람이 누구인지 알기위한 변수

            for (int i = 0; i < lab2AssignmentArray.Length;)  //for문을 사용해서 배열의 길이만큼 반복하는 루프를 생성
            {               
                //생각으로는 if에 최대값을 구하는것과 동일하게 안에 for문을 만들어서 배열을 j회 반복하게 만들고
                //!= 마다 증가하는 검증 카운트를 j로 초기화 하고 if(j=검증카운트)를 통과한다면 i2가 증가하는 방식으로 
                //

                Console.Write("{0}번째 학생이 아침에 먹은 사과의 개수를 입력하세요(0보다 커야합니다.)",i+1); //사용자에게 지시사항을 전달했습니다. i = 0 이기 때문에 +1을 해서 순서를 표기했습니다.
                int.TryParse(Console.ReadLine(), out lab2AssignmentArray[i]); //예외 사항이라면 0이 입력되는 트라이파스를 이용해서 숫자만 입력되게 만들었습니다.
                if (lab2AssignmentArray[i] > 0){i++;} //제대로 입력하지 않는다면 for문이 끝나지 않는 방식으로 검증했습니다.
                else {Console.WriteLine("\n멍청한 녀석 제대로 입력하세요.\n");} //두줄 다 짧고 복잡하지 않아서 그냥 그줄에 isNothing처럼 배치했는데 상관없을까요?
            } //유저값을 입력받는 루프

            for (int i = 0; i < lab2AssignmentArray.Length; i++) //모든 수를 비교하기 위해 배열 크기만큼 루프해서
            {
                if (assignment2Max < lab2AssignmentArray[i]) //저장된 최대값보다 i번째 루프하는 배열속의 element가 더 크다면 실행되는 조건으로
                {
                    assignment2Max = lab2AssignmentArray[i]; //i번째 요소를 최대값에 대입하는 방식으로 최대값을 전부 비교해서 찾는 방식을 사용했습니다.
                    assignment2MaxP = i + 1; //대입이 발생할때 몇번째 사람이 최대인지 기록하는 용도로 사용했습니다.
                }
            } //최대값을 구하는 루프

            int assignment2Min = assignment2Max; // 최소값을 찾는 변수
            int assignment2MinP = 0; //최소값을 입력한 사람이 누구인지 찾는 변수

            for (int i = 0; i < lab2AssignmentArray.Length; i++) //모든 수를 비교하기 위해 배열 크기만큼 루프해서
            {
                if (assignment2Min > lab2AssignmentArray[i]) //저장된 최소값보다 i번째 루프하는 배열속의 element가 더 작다면 실행되는 조건으로
                {
                    assignment2Min = lab2AssignmentArray[i]; //i번째 요소를 최소값에 대입하는 방식으로 최소값을 전부 비교해서 찾는 방식을 사용했습니다.
                    assignment2MinP = i + 1; //대입이 발생할때 몇번째 사람이 최소인지 기록하는 용도로 사용했습니다.
                }
            } //최소값을 구하는 루프

            Console.WriteLine("최소값을 입력한 학생은 {0}번째 학생이였고 {1}개의 사과를 아침에 먹었습니다.", assignment2MinP, assignment2Min);
            Console.WriteLine("최대값을 입력한 학생은 {0}번째 학생이였고 {1}개의 사과를 아침에 먹었습니다.", assignment2MaxP, assignment2Max);
            int savePoint = 0; //버블 솔트를 사용하기 위한 큰수 저장지점

            for (int i = 0; i < lab2AssignmentArray.LongLength - 1; i++)  //버블 솔트를 배열길이 -1 만큼 반복하기 위한 for문 
            {
                for (int j = 0; j < lab2AssignmentArray.LongLength - 1; j++) //버블 솔드를 배열길이 -1만큼 해서 맨 앞의 가장 큰 값도 맨뒤로 갈수있게 설정 
                {
                    if (lab2AssignmentArray[j] > lab2AssignmentArray[j + 1]) //j번 배열이 j+1 배열보다 크다면 실행
                    {
                        savePoint = lab2AssignmentArray[j]; //큰 배열 요소를 잠깐 저장해둠
                        lab2AssignmentArray[j] = lab2AssignmentArray[j + 1]; // 작은 배열 요소를 큰 배열 요소로 대입
                        lab2AssignmentArray[j + 1] = savePoint; 
                    }
                }
            } //저장해둔 수를 작은 배열 요소로 대입 이렇게 0번 배열의 큰수가 1번 배열로 이동하는것을 반복 수행해서 배열을 숫자 순서대로 정열하는것을 버블 정렬이라고 한다.
            for (int i = 0; i < lab2AssignmentArray.Length; i ++) //배열 길이만큼 반복해서
            {
                Console.WriteLine("{0}\t",lab2AssignmentArray[i]); //버블 정렬로 순서대로 정렬된 배열을 작은수부터 큰수 순서대로 출력한다.
            }  





        }
    }
}