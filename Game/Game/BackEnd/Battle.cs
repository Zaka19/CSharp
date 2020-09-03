using Game.Characters;
using Game.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Game.BackEnd
{
    class Battle
    {

        public bool DetectEnemys(Generics[,] _generic, Hero _hero)
        {
            bool detect = false;

            for (int a = _hero.Position.X - 1; a <= _hero.Position.X + 1; a++)
            {
                for (int b = _hero.Position.Y - 1; b <= _hero.Position.Y + 1; b++)
                {
                    if (_generic[a, b].Name == "Slug")
                    {
                        detect = true;
                    }
                }
            }

            return detect;
        }


        public List<Generics> DetectNumberEnemys(Generics[,] _generic, Hero _hero)
        {
            List<Generics> _enemysRelease = new List<Generics>();

            for(int a = _hero.Position.X - 1; a <= _hero.Position.X + 1; a++)
            {
                for (int b = _hero.Position.Y - 1; b <= _hero.Position.Y + 1; b++)
                {
                    if(_generic[a,b].Name == "Slug")
                    {
                        _enemysRelease.Add(_generic[a, b]);
                    }
                }
            }

            return _enemysRelease;
        }

        public void VisualizarBatalla(List<Generics> _enemys, Hero heroe)
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(" /$$$$$$$             /$$              /$$ /$$           /$$ /$$ /$$");
            Console.WriteLine("| $$__  $$           | $$             | $$| $$          | $$| $$| $$");
            Console.WriteLine("| $$  / $$ /$$$$$$  /$$$$$$   /$$$$$$ | $$| $$  /$$$$$$ | $$| $$| $$");
            Console.WriteLine("| $$$$$$$ |____  $$|_  $$_/  |____  $$| $$| $$ |____  $$| $$| $$| $$");
            Console.WriteLine("| $$__  $$ /$$$$$$$  | $$     /$$$$$$$| $$| $$  /$$$$$$$|__/|__/|__/");
            Console.WriteLine("| $$  / $$/$$__  $$  | $$ /$$/$$__  $$| $$| $$ /$$__  $$            ");
            Console.WriteLine("| $$$$$$$/  $$$$$$$  |  $$$$/  $$$$$$$| $$| $$|  $$$$$$$ /$$ /$$ /$$");
            Console.WriteLine("|_______/ /_______/   /___/  /_______/|__/|__/ /_______/|__/|__/|__/");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("DRAGON");
            foreach (Enemy monster in _enemys)
            {
                Console.WriteLine(monster.ToString());

                string dragon = @"                                      
                                                      .~)>>
                                                    .~))))>>>
                                                  .~))>>             ___
                                                .~))>>)))>>      .-~))>>  
                                              .~)))))>>       .-~))>>)>
                                            .~)))>>))))>>  .-~)>>)>
                        )                 .~))>>))))>>  .-~)))))>>)>
                     ( )@@*)             //)>))))))  .-~))))>>)>
                   ).@(@@               //))>>))) .-~))>>)))))>>)>
                 (( @.@).              //))))) .-~)>>)))))>>)>
               ))  )@@*.@@ )          //)>))) //))))))>>))))>>)>
            ((  ((@@@.@@             |/))))) //)))))>>)))>>)>
           )) @@*. )@@ )   (\_(\-\b  |))>)) //)))>>)))))))>>)>
         (( @@@(.@(@ .    _/`-`  ~|b |>))) //)>>)))))))>>)>
          )* @@@ )@*     (@) (@)  /\b|))) //))))))>>))))>>
        (( @. )@( @ .   _/       /  \b)) //))>>)))))>>>_._
         )@@ (@@*)@@.  (6,   6) / ^  \b)//))))))>>)))>>   ~~-.
      ( @jgs@@. @@@.*@_ ~^~^~, /\  ^  \b/)>>))))>>      _.     `,
       ((@@ @@@*.(@@ .   \^^^/' (  ^   \b)))>>        .'         `,
        ((@@).*@@ )@ )    `-'   ((   ^  ~)_          /             `,
          (@@. (@@ ).           (((   ^    `\        |               `.
            (*.@*              / ((((        \        \      .         `.
                              /   (((((  \    \    _.-~\     Y,         ;
                             /   / (((((( \    \.-~   _.` _.-~`,       ;
                            /   /   `(((((()    )    (((((~      `,     ;
                          _/  _/      ` /   /'                  ;     ;
                      _.- ~_.- ~           /  / '                _.-~   _
                    ((((~~              / / '              _.-~ __.--~
                                       ((((__.- ~_.- ~
                                                                             ";
                Console.WriteLine(dragon);
                Thread.Sleep(2000);
                Console.Clear();
            }
            string vs = @"    
                               /.  ./| /  /    '   
                             .-' . ' ||  :  /`./   
                            /___/ \: ||  :  ;_     
                            .   \  ' . \  \    `.  
                             \   \   '  `----.   \ 
                              \   \    /  /`--'  / 
                               \   \ |'--'.     /  
                                '---    --'---'   ";
            Console.WriteLine(vs);
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("HEROE");
            Console.WriteLine(heroe.ToString());
            string Heroe = @"
                          ,dM
                         dMMP
                        dMMM'
                        \MM/
                        dMMm.
                       dMMP'_\---.
                      _| _  p ;88;`.
                    ,db; p >  ;8P|  `.
                   (``T8b,__,'dP |   |
                   |   `Y8b..dP  ;_  |
                   |    |`T88P_ /  `\;
                   :_.-~|d8P'`Y/    /
                    \_   TP    ;   7`\
           ,,__      >   `._  /'  /   `\_
         `._     ~~~~------|`\;' ;     ,'
             ~~~-----~~~'\__[|;' _.- '  `\
                    ; --..._.- '-._     ;
                    /      /`~~ '   ,'`\_ ,/
                   ; _ / '        /    ,/
                    | `~-l;    /
                  `\    ;       /\.._ |
                    \    \      \     \
                    /`---';      `----'
                   (     / 
                    `---'             ";

            Console.WriteLine(Heroe);
            Thread.Sleep(2000);
            Console.Clear();

            string Fight = @"   
                                  .--.,   ,--,             ,--.' |     ,--.'|_   
                                ,--.'  \,--.'|             |  |  :     |  | :,'  
                                |  | /\/|  |,     ,----._,.:  :  :     :  : ' :  
                                :  : :  `--'_    /   /  ' /:  |  |,--.;__,'  /   
                                :  | |-,,' ,'|  |   :     ||  :  '   |  |   |    
                                |  : :/|'  | |  |   | .\  .|  |   /' :__,'| :    
                                |  |  .'|  | :  .   ; ';  |'  :  | | | '  : |__  
                                '  : '  '  : |__'   .   . ||  |  ' | : |  | '.'| 
                                |  | |  |  | '.'|`---`-'| ||  :  :_:,' ;  :    ; 
                                |  : \  ;  :    ;.'__/\_: ||  | ,'     |  ,   /  
                                |  |,'  |  ,   / |   :    :`--''        ---`-'   
                                `--'     ---`-'   \   \  /                       
                                                   `--`-'    ";

            Console.WriteLine(Fight);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
