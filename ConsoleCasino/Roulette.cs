﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    public class Roulette
    {
        private List<int> roulette = new List<int>() {0, 5, 12, 3, 10, 1, 8, 9, 2, 7, 6, 11, 4 };
        private List<string> rouletteImg = new List<string>()
        {
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@       0       @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@            0            @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@               @#              @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@              .@@@@@@              @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                 @@@/                @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                   @@@/                 @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                   @@@/                  @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    @@@/                  *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                    @@@/                   @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                    @@@/                  *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                    5    @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                     5         @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                 (@@@@@.           @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                   %@@@@@            @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                   .@@@/                @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                  @@@@                   @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                 &@@@                     *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@               .@@@*                       @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                                          *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                           12  @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                    *      12      @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                      /@@@@          @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                   #@@@@@@@@            @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@             ,@@@@@@@*     .             @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@             .@@%                         *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                                           @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                                          *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                                     @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                                        @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                          @@*            @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@             @@@@@@@@@@@@@@@@@@33333333333 *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                           @%              @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                                          *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                                     @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@             /@@&                       @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@               @@@@@&                    @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    &@@@@& .@             *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                        &@@@@&             @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                        ,@@(.  10         *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                10       @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                  10     @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                  10 @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                 
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##             ,&                      @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@               @@@@.                    @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                 %@@@/                   @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    *@@@&                 *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                       @@@@@&              @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                       *@@@@#             *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                             1           @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                              1         @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                             1       @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                             1    %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                            1 @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                #@@/                 @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                   @@@                  @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                   #@@/                  @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                     @@@                  *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                     #@@/                  @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                   *#@@@@@(               *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                     *@@                 @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                        8               @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                       8             @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                       8          %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                      8       @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                    8   @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                   .@@@              @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                     @@@.               @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                    #@@(                 @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    ,@@@                  *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                    @@@                    @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                  @@@@@#.                 *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                  /@/                    @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                 9                      @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#              9                      @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@            9                     %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@         9                    @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@     9                  @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                       .@            @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                       /@@@#            @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                     %@@@*               @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    @@@@.                 *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                @@@@@%                     @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                @@@@@.                    *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@              2                          @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&             2                          @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#          2                          @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@        2                         %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@     2                        @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@ 2                      @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                                     @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                          #@@.          @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@                     .&@@@@%.            @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@               *@ *@@@@@#                 *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@               @@@@@*                      @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@             7  ./&@                      *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@           7                             @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&          7                             @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#       7                             @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@     7                            %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@  7                           @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@                               @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@                                   @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##                                     @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@                                        @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@              /@/                        @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@ 6666666666666/@@@@@@@@@@@@@@@@@/          *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                &#                         @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                                          *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@                         @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@ 11                             @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@     11                             @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##        11                           @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@             ,%@@@/                     @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@              &@@@@@#                    @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@               .(  .%@@@@%.               *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                        (@@@@@*            @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                            *%            *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                                         @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 ",
            @"                                                                                
                                  ,(((((((((((.                                 
                         ,@@@@@/((((((((/((((((((%%%%%%                         
                     @@@@@@@@@@@/(((((( ( ((((((/%%%%%%%%%%%                    
                 @@@@@@@  @@@@@@#(((((( # (((((/%%%%%%%   #%%%%/                
              %#/@@@@@@@ /  @@@@@/(((((((((((((#%%%%%/%% %%%%%%#/@.             
           .%%%%%%/@@@@@@@@@@@@@(@(@@@@@@@@@@@/&(%%#%%%%%%%%%%(@@@@@@.          
         .%%#%%%%%%%/@@@@@#@@@@@@@%@@@@@@@@@@(@@@@@@@(%%%%%#&@@@@@@@@@@.        
       .%%#%%   %%%%%%/#@@@@@@@@@               @@@@@@@@@/@@@@@@@@  @@@@/.      
      ,%%%%  (%%%%%%(@@@&%@@     4                   @@/@@@&@@@.@@@@&% @@@,     
    .##%%%%%%%%#%%(@@@@@@         4                     @@@@@&@@@ %@@@@@@@@.    
    @@#//#%%%%%%%@@@@@@            4                      @@@@@@@@@@@@@&/(%#,   
   .@@@@@@@@&(//@@@@##              #(*.                   @@@@@%//#%%%%%%%%%/  
  (@@@@@@@@@@@@@@@@@               ,@@@@                    @@@@@(%%%%%%%%%%%*. 
  .@@% @   @@@(@@@@@               %. &@@#                   @@@@@%%%%(%#./%%%( 
 .@@@@@   .@@@@@@@@                    .@@@/                 *@@@@(%%.  % #%%%* 
 ,@@@@@@@@@@@@@@@@@                      *@@@,                @@@@/%%%%%%%%%%%, 
 .@@@@@@@@@@@&%///@                        #@@@              *///((%%%%#%%%%%%, 
  ,%%%%%%%%%%%(@@@@@                         %.              @@@@@@@@@@@@@@&%%/ 
  /%%%%%%%%%%%%@@@@&                                        @@@@@(@@@@@@@@@@@*  
   ,%%%##%%%%%%#@@@@@#                                     @@@@@(@@@&  / @@@@/  
    #%%,.%%%%%%%%@@@@/@                                  %/%@@@(@@# .  @@@@@,   
     %%%%%%%%%%%%(/@@@@@@                              @@@@@@@/@@@@@&   @@@.    
      *#%%%%%%/%@@@@/@@@@@@@                        @@@@@@@@%%%%%(/@@@@@@@,     
       .##//@@@@@@@@@@@@@@@@@/@@@              @@@&&@@@@@(%%%%%%%%%%%/%@%       
         *@@@@@@@@@@ *@@@@/@/@@@@@@@@@@@/@@@@@@@@@@@(&#%%%% %%%%%%%%%%%.        
           ,@@@@ @@@@@@@@@%(%%#(&@@@@@@@/@@@@@@@/@@@@/%%%%%%% .%%%%%%.          
              @@@@@@@@@@@/#%%%%%%%%%%%%%/@@@@@@@@@@@@@(#%%%%%%%%#%*             
                 @@@@@@@/%%%%%% %*#%%%%%/@@@@@ @ @@@@@@%/%%%%%%(                
                    (@%(%%%%%%/,% %%%%%%/@@@@@%#&,@@@@@@&/#%                    
                         #%%%%%%%%%%%%%%/@@@@@@@@@@@@@@                         
                                 .#%%#%%/@@@@@(                                 "
        };
        private Random random = new Random();
        private int rand;
        private int number;
        public int time = 100;
        public int bid;
        public void Game(Account account)
        {
            Console.Write("Twój zakład: ");
            bid = Int32.Parse(Console.ReadLine());
            if(account.getBalance()>bid)
            {
                Spin();
            }
        }
        public void Spin()
        {
            rand = (random.Next() % 20) + 10;
            number = rand;
            int write;
            while (rand != 0)
            {
                Console.Clear();
                write = (number % roulette.Count);
                Console.Write(rouletteImg[write]);
                rand--;
                number++;
                Thread.Sleep(time);
                time += 20;
            }
        }
    }
}
