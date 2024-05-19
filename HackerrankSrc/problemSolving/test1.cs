﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'doesCircleExist' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY commands as parameter.
     */

    public static List<string> doesCircleExist(List<string> commands)
    {
        

        List<string> results = new List<string>();

        foreach (var c in commands)
        {
            Console.WriteLine(c);

            var set = c + c +c +c;

            var x = 0;
            var y = 0;
            char d = 'N';

            if(c.All(t => t == 'G'))
            {
                results.Add("NO");
                continue;
            }
            if (c.All(t => t == 'R' || t == 'L'))
            {
                results.Add("YES");
                continue;
            }

            for (int i = 0; i< set.Length; i++)
            {
                var cmd = set[i];
                if (cmd == 'G')
                {
                    if (d == 'N')
                        y++;
                    else if (d == 'S')
                        y--;

                    else if (d == 'E')
                        x++;
                    else if (d == 'W')
                        x--;
                }

                if(cmd == 'R')
                {
                    if (d == 'N')
                    {
                        d = 'E';
                    }
                    else if (d == 'E')
                    {
                        d = 'S';
                    }
                    else if (d == 'S')
                    {
                        d = 'W';
                    }
                    else if (d == 'W')
                    {
                        d = 'N';
                    }
                }

                if (cmd == 'L')
                {
                    if (d == 'N')
                    {
                        d = 'W';
                    }
                    else if (d == 'W')
                    {
                        d = 'S';
                    }
                    else if (d == 'S')
                    {
                        d = 'E';
                    }
                    else if (d == 'E')
                    {
                        d = 'N';
                    }
                }

                if (hasCircle(x, y, d))
                {
                    results.Add("YES");
                    break;
                }

            }
            results.Add("NO");
        }

        return results;
    }


    
    static bool hasCircle(int x, int y, char d)
    {
        var s = $"{x}_{y}_{d}";
        if (s == "0_0_N")
            return true;
        return false;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int commandsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> commands = new List<string>();

        //for (int i = 0; i < commandsCount; i++)
        //{
        //    string commandsItem = Console.ReadLine();
        //    commands.Add(commandsItem);
        //}
        //commands.Add("GGGGR");
        commands.Add("RGL");

        List<string> result = Result.doesCircleExist(commands);

        //textWriter.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}



//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;



//class Result
//{

//    /*
//     * Complete the 'minimalHeaviestSetA' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static List<int> minimalHeaviestSetA(List<int> arr)
//    {
//        arr.Sort();


//        long sum = 0;

//        for (int i = 0; i < arr.Count; i++)
//        {
//            sum += arr[i];
//        }
//        List<int> setA = new List<int>();

//        long setASum = 0;

//        for (int i = arr.Count - 1; i >= 0; i--)
//        {



//            setASum += arr[i];
//            setA.Add(arr[i]);

//            if (setASum > sum - setASum)
//            {
//                break;
//            }
//        }

//        setA.Sort();
//        return setA;

//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//        //List<int> arr = new List<int>();

//        //for (int i = 0; i < arrCount; i++)
//        //{
//        //    int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//        //    arr.Add(arrItem);
//        //}

//        List<int> result = Result.minimalHeaviestSetA(new List<int>() { 99398, 90664, 95026, 93226, 99364, 94435, 93954, 94169, 92725, 96487, 99082, 98044, 94770, 97527, 92038, 90138, 99713, 96057, 95285, 92107, 92471, 90643, 95207, 94180, 99630, 91667, 90043, 96867, 99827, 98216, 94966, 96169, 94520, 99753, 96852, 91038, 92455, 90177, 98181, 95629, 95003, 94002, 92873, 91745, 94974, 90518, 96869, 98817, 98533, 91981, 92773, 99707, 98386, 96181, 90987, 90730, 96560, 92039, 99415, 93343, 96757, 99288, 90039, 93158, 99541, 99748, 93458, 99176, 98419, 98226, 91815, 92406, 91249, 95634, 96448, 98426, 99370, 95593, 99094, 92850, 96316, 98458, 94457, 92165, 99078, 93502, 97618, 94923, 97470, 90802, 91848, 99927, 91380, 99268, 91168, 98683, 91397, 96227, 97242, 99148, 95671, 96968, 92056, 96602, 94682, 99749, 96241, 95324, 96084, 92903, 97856, 91689, 93768, 95897, 97998, 95269, 98843, 95443, 97693, 99599, 95389, 91112, 95179, 98349, 90502, 92287, 93913, 95843, 96408, 99740, 99420, 93085, 92252, 90638, 97451, 91754, 94517, 95382, 96814, 99005, 97998, 98288, 97719, 95316, 93736, 91858, 90523, 96120, 96393, 96144, 90331, 95511, 91165, 90534, 90083, 96916, 99539, 95183, 98494, 91305, 93925, 93284, 99452, 98245, 93536, 93354, 96376, 98907, 97741, 92838, 98403, 92987, 98581, 90433, 95276, 93437, 91109, 94769, 94305, 93880, 98813, 91336, 95911, 93635, 91487, 97883, 93872, 94390, 94595, 90903, 92653, 90738, 92469, 92273, 96962, 94010, 92432, 95652, 98023, 95172, 93375, 96782, 96973, 97869, 90219, 90525, 98260, 97172, 95203, 90147, 94926, 93028, 98016, 91119, 93310, 99983, 99399, 92575, 96797, 96363, 97044, 94413, 97020, 96757, 98376, 97008, 96165, 91392, 92092, 93517, 95886, 94792, 99241, 91837, 96760, 93955, 95042, 94414, 97159, 93242, 94659, 99319, 91963, 99109, 99696, 95245, 99638, 92922, 97321, 96466, 90842, 94136, 90609, 91111, 92967, 99361, 96940, 97648, 92788, 95034, 91118, 99918, 93750, 92710, 91234, 90681, 95323, 96387, 98259, 97269, 99323, 90658, 94832, 90643, 92152, 96988, 94783, 90909, 92476, 92985, 92564, 98202, 91029, 96094, 90941, 97727, 92974, 98874, 96052, 91681, 93496, 97709, 91259, 98840, 94176, 90627, 95086, 94640, 91092, 92766, 93986, 90736, 95577, 99915, 97688, 93230, 95068, 91601, 93402, 93020, 94609, 95186, 95348, 90066, 99210, 91586, 97700, 95739, 93491, 91381, 92347, 93893, 97817, 97326, 97628, 91818, 99484, 95574, 90635, 96788, 93419, 93280, 93575, 92599, 99335, 94676, 94190, 93160, 91295, 91204, 91324, 96995, 91266, 93835, 99320, 97318, 90372, 97299, 99139, 97274, 90297, 96672, 99843, 98842, 92562, 96433, 91394, 96969, 95244, 90971, 98593, 97536, 95124, 93334, 96444, 98934, 98206, 95964, 99197, 92210, 93103, 93133, 98924, 94037, 99855, 99852, 94574, 90047, 91431, 96136, 99176, 93523, 96361, 98677, 91087, 95826, 98751, 94212, 94998, 90528, 96262, 90190, 99812, 92736, 97545, 98673, 93409, 98770, 98111, 98853, 98854, 99067, 97619, 92046, 92632, 98918, 92199, 90583, 93163, 97514, 92533, 98593, 96981, 95644, 92204, 98407, 90793, 96353, 91038, 90987, 99852, 90876, 95062, 92628, 97052, 94267, 98087, 93014, 92514, 91249, 99888, 91653, 90482, 93055, 92503, 90684, 98894, 90265, 99271, 92112, 97120, 94994, 90855, 96636, 99054, 98174, 98764, 99397, 91990, 94115, 99632, 95226, 96546, 95080, 92877, 92262, 99250, 93141, 90271, 98167, 97358, 95279, 98410, 97605, 94975, 90351, 94121, 93115, 90620, 93340, 98434, 94077, 98979, 93130, 96899, 90078, 93802, 94934, 92750, 95640, 94659, 97458, 94722, 93040, 97554, 97920, 93132, 98719, 98287, 95090, 96281, 96667, 97928, 91696, 94192, 99066, 91691, 92709, 98218, 90491, 96147, 95326, 93175, 96984, 94783, 99772, 93294, 95455, 98624, 97439, 94511, 92029, 96882, 94348, 93405, 90184, 92434, 93425, 97433, 90837, 98254, 98669, 92015, 96895, 93930, 97922, 97503, 94200, 95842, 98679, 93092, 99301, 90686, 93109, 95339, 92022, 99613, 94325, 96095, 97405, 99488, 95807, 98389, 97297, 98478, 99849, 99100, 96565, 95542, 98909, 94052, 92735, 97222, 95844, 94635, 90714, 90615, 95122, 94979, 96168, 98392, 97329, 95271, 92118, 90284, 93559, 99871, 93376, 95598, 94593, 98579, 92543, 93013, 92165, 95591, 99455, 97150, 96087, 93484, 93237, 96230, 91497, 98914, 92369, 91506, 95096, 92610, 93588, 97112, 97862, 98733, 94817, 98444, 94463, 97682, 90853, 98274, 96318, 92047, 93045, 92432, 96128, 97549, 95839, 91046, 96558, 99540, 93733, 97126, 94727, 90905, 91907, 91551, 97166, 99081, 92605, 92438, 97008, 98272, 97210, 97259, 96268, 97966, 90869, 98135, 91345, 90328, 92511, 94234, 99080, 97213, 98150, 90399, 94074, 92127, 99494, 97747, 95359, 93741, 93019, 90300, 91936, 95312, 96938, 91469, 92273, 98741, 94778, 95629, 92369, 92862, 94634, 92931, 90686, 93078, 92612, 90029, 95919, 93460, 97435, 95439, 95373, 93021, 90756, 95882, 97512, 95057, 94319, 99163, 92173, 92143, 90796, 99879, 95863, 99679, 99846, 96561, 97590, 97695, 94758, 92741, 92765, 94074, 97897, 99868, 98836, 92282, 95087, 97010, 96527, 93253, 90066, 90818, 94845, 94166, 90180, 99386, 96305, 96501, 93609, 95313, 91251, 92001, 96587, 96522, 96601, 97924, 96307, 98221, 94836, 92340, 91515, 95751, 93675, 96113, 98146, 96012, 95473, 90713, 91779, 94673, 98133, 99978, 92190, 97408, 96048, 99619, 97810, 96054, 90446, 90340, 99522, 94766, 93393, 99232, 93887, 96982, 98663, 99339, 95654, 91368, 95714, 99157, 98184, 93722, 90067, 92237, 98270, 92330, 94545, 92038, 98806, 96216, 91042, 98676, 98690, 99309, 91717, 92368, 94419, 98685, 91905, 92972, 91956, 91720, 94359, 96283, 90609, 95253, 95952, 95509, 92886, 99648, 93439, 90698, 95625, 92067, 94494, 99809, 98019, 96148, 93852, 92572, 91611, 99836, 92121, 92333, 95803, 99141, 96556, 91651, 99974, 93248, 98968, 94610, 99925, 95587, 95777, 92488, 92021, 96206, 99230, 99738, 93163, 93141, 96776, 94073, 98496, 94319, 97691, 97842, 91640, 96979, 92202, 97885, 94147, 98617, 98520, 97552, 91864, 91995, 97522, 97694, 95959, 96908, 93090, 93083, 95435, 93066, 98549, 96930, 96184, 91737, 96089, 98973, 98810, 98567, 96567, 91933, 93808, 96399, 91669, 97053, 97997, 94856, 99068, 91914, 90568, 92928, 93892, 92728, 90565, 91895, 96605, 98947, 90182, 98532, 98237, 90133, 99866, 92727, 98763, 93805, 91895, 99409, 93424, 98226, 98823, 91988, 94772, 95959, 91995, 93382, 95311, 92409, 93198, 91158, 96754, 98576, 99421, 95310, 97114, 98724, 96703, 90745, 96115, 91820, 94094, 91719, 92732, 90213, 92841, 92094, 96098, 90279, 99122, 93592, 92401, 97501, 90864, 94016, 95997, 92849, 90480, 98763, 92466, 98177, 95730, 91944, 95042, 95880, 90332, 97871, 93511, 92040, 94434, 99789, 96462, 92918, 92603, 90307, 93603, 91789, 93610, 97217, 94733, 96853, 91946, 99107, 95929, 91215, 95769, 97516, 91528, 92801, 99732, 96231, 92551, 95469, 94074, 93780, 98360, 92533, 93198, 92182, 98568, 90489, 98023, 93566, 96441, 93780, 96386, 96397, 93425, 91136, 94922, 94760, 96756, 90223, 94003, 97368, 98629, 90121, 94546, 97814, 95865, 90504, 91839, 93929, 93636, 92297, 96842, 92071, 95434, 97060, 99875, 91663, 94161, 91374, 95097, 96362, 96017, 98114, 96704, 90868, 99668, 98637, 99408, 96577, 98073, 98641, 96416, 95026, 99310, 95737, 97879, 95397, 95755, 98620, 91568, 91225, 98053, 96118, 95400, 91890, 91449, 99406, 98368, 96480, 97271, 92156, 92397, 91170, 91602, 91534, 92719, 96396, 96543, 97585, 98448, 96794, 96813, 99776, 98243, 95110, 95931, 97265, 98131, 91123, 91724, 93771, 99927, 97980, 90479, 98882, 98992, 91310, 92707, 95054, 99520, 90937, 91207, 93633, 94032, 91138, 93845, 93795, 91306, 92968, 99346, 95476, 93561, 91386, 94238, 91077, 99411, 90672, 93080, 91015, 93841, 93924, 92114, 95030, 90237, 96317, 98539, 94584, 92375, 97230, 93783, 91634, 96201, 93366, 99326, 95610, 92226, 93533, 97912, 93529, 99370, 95906, 91306, 97814, 90269, 90262, 98152, 92633, 96157, 90925, 91940, 92331, 96733, 91012, 99611, 94899, 96690, 94883, 95902, 99310, 95935, 93710, 97187, 98033, 95001, 98524, 91255, 95076, 90574, 96187, 96269, 95484, 98656, 96379, 92928, 94406, 94483, 91838, 98810, 92533, 98967, 99891, 92761, 90014, 91213, 90581, 90281, 92805, 95414, 95622, 97873, 93788, 98325, 92799, 95518, 96011, 90414, 92482, 91611, 96875, 99793, 96460, 93966, 90259, 93069, 94422, 93842, 98163, 91377, 90126, 97322, 94732, 93018, 97538, 99831, 93247, 96370, 97018, 95104, 91077, 98041, 93042, 99490, 98436, 91584, 97862, 96127, 94305, 91531, 90020, 91220, 96883, 95973, 92690, 96419, 96538, 98482, 94455, 97143, 96396, 96763, 94307, 96566, 99406, 91112, 93430, 98947, 91015, 90483, 98602, 94005, 93440, 97768, 95979, 96121, 90909, 98768, 99415, 98271, 95248, 91229, 94516, 90841, 97678, 91331, 98149, 99697, 95830, 95058, 93299, 96246, 94618, 90972, 90813, 94594, 95819, 99123, 92860, 97382, 94034, 98019, 97712, 92390, 95995, 97924, 91868, 96559, 96151, 94075, 93455, 92772, 93874, 97859, 90343, 97383, 96716, 97460, 97499, 93300, 99704, 92057, 90694, 94222, 92840, 95227, 97909, 90538, 97682, 93928, 95502, 96364, 99170, 99137, 93531, 90175, 90712, 93033, 93509, 98618, 98942, 95474, 92283, 94177, 99534, 99437, 97759, 92629, 97006, 91084, 95748, 95446, 99524, 95158, 92319, 95649, 94373, 90523, 92771, 93024, 91011, 93854, 96546, 96036, 96366, 91688, 97255, 93324, 91410, 92378, 98337, 97227, 98947, 99829, 97844, 95415, 90004, 90334, 90300, 94455, 90282, 92308, 99701, 90851, 98686, 96265, 95304, 90958, 97123, 99001, 91066, 91074, 94495, 91612, 90347, 92935, 98065, 95719, 99791, 97879, 92247, 96067, 90185, 95027, 98264, 90529, 97549, 94955, 98098, 90464, 94672, 90552, 92677, 95370, 91922, 91015, 97357, 95830, 96254, 93275, 97394, 97829, 99035, 97519, 92353, 99740, 96563, 99961, 91134, 90472, 91967, 96494, 98704, 93595, 93556, 95469, 91476, 97613, 92611, 96466, 90781, 96971, 93145, 94643, 92897, 91894, 97180, 97006, 99705, 97660, 91760, 97771, 96184, 95574, 98067, 94904, 99695, 98540, 98797, 98844, 91287, 93890, 97238, 97468, 91075, 94913, 90387, 98404, 98195, 90397, 98870, 90971, 90775, 98426, 98445, 95210, 92895, 96641, 91414, 94738, 93644, 96237, 91424, 93505, 97983, 91083, 91787, 93896, 90387, 96520, 95745, 95119, 90009, 94617, 96887, 96279, 90449, 93986, 99321, 98184, 98117, 92602, 90127, 91510, 90676, 91509, 91145, 96708, 91045, 95762, 93180, 92761, 93063, 96528, 93370, 97770, 92075, 94858, 95629, 94198, 97407, 93331, 94833, 95594, 93982, 96498, 97733, 99618, 97199, 94863, 97469, 94257, 98563, 99981, 93972, 90297, 99563, 90201, 99561, 93291, 97815, 97549, 97609, 92539, 92564, 96305, 92265, 92940, 96335, 92934, 98922, 97947, 95710, 95207, 98363, 98322, 97005, 95585, 92334, 91918, 91969, 90241, 94683, 94258, 94535, 90445, 90115, 98375, 92109, 97475, 92142, 95029, 93943, 95687, 92865, 91235, 94702, 90954, 99836, 95815, 93529, 93255, 99465, 95632, 97591, 92905, 92153, 95073, 94420, 99634, 91695, 94393, 99157, 92524, 90320, 99612, 91261, 96690, 91214, 97777, 90192, 99482, 92361, 96632, 91107, 95006, 99094, 96994, 99717, 90791, 97888, 99465, 90108, 94551, 90609, 94498, 90541, 92147, 96682, 96299, 90037, 90112, 90471, 96567, 92903, 97394, 92511, 93624, 99245, 91325, 96210, 96186, 97008, 92246, 96113, 98667, 95103, 99734, 99885, 96729, 97773, 90879, 93819, 97579, 97516, 97716, 90838, 99452, 97612, 96552, 90732, 98614, 95556, 96695, 94672, 90308, 95579, 99873, 99927, 92076, 91816, 94497, 96151, 94088, 93681, 90847, 91601, 91283, 91517, 94247, 96221, 96397, 93691, 93338, 98641, 91308, 95979, 99683, 95850, 96475, 90277, 93084, 97529, 94756, 92491, 94274, 91869, 96363, 98768, 92886, 96050, 96324, 95175, 94021, 92526, 94435, 98374, 91115, 91735, 90426, 93897, 96323, 92937, 93792, 94191, 92166, 97497, 98612, 90811, 99803, 93133, 98530, 93794, 99987, 93387, 96061, 96594, 92452, 93898, 93390, 96757, 98326, 95937, 98894, 90947, 98002, 98095, 94802, 97903, 93817, 99020, 96566, 94429, 92894, 97673, 93820, 97623, 90544, 92675, 96105, 91210, 98722, 99048, 93966, 95063, 97224, 98849, 97437, 94780, 97550, 92066, 99490, 92518, 90622, 95489, 91575, 91226, 99970, 90216, 92042, 91844, 91348, 92949, 95915, 97113, 98294, 92328, 96285, 96205, 90661, 99132, 93402, 91555, 99755, 98411, 97433, 92990, 99419, 92333, 94829, 94548, 97106, 94856, 96242, 96201, 92798, 93220, 96018, 9612 });

//        var s = String.Join("\n", result);
//        //textWriter.WriteLine(String.Join("\n", result));

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}
