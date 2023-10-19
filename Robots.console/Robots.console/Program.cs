// See https://aka.ms/new-console-template for more information
using Robots;

//Robot unRobot = new Robot("Ardit", 0, 0);
RobotMobile unRobotMobile = new RobotMobile("Usain Bolt", 0, 0, 10);

//Robot deuxRobot = new Robot("Ardito", 2, 4);

//unRobot.avancer(4, 6);
//deuxRobot.avancer(3, 5);
//Console.WriteLine(unRobot.afficherPosition());
//Console.WriteLine(deuxRobot.afficherPosition());
unRobotMobile.avancer(10, 10);
Console.WriteLine(unRobotMobile.CalculerDuréeDeDéplacement(100, 100));
Console.WriteLine(unRobotMobile.afficherPosition());
