



/*
 
RUBY CODE
  
 *10 / 14 / 21 - This is the second version of my random character creator for DND. The first version prooved the basic system and taught me some stuff about arrays, sampling, and checking those samples. This version will adjust the system to be more fluid, and flesh out the name arrays. After that is built out more thoroughly I'll move on to back stories and more fleshing out of characters. Once that is solid I will move on to stat blocks. If I'm still working on this by then I'll figure out how to export to a txt file and eventually a writable character sheet pdf.

I worked out with josh how to make use a while loop to ask the user what their level is, and re-ask if they enter a number outside the accepted range, then move forward if an acceptable number is given. Not useful this early on, but will be when stats come in to play.

10/17/21 - Figured out a while loop to roll four 6 sided die, subtract the lowest number, and sum them, fulfilling the classic method of stat determination. Features added: Ability score #s based on dice rolls.

10/18/21 - Figured out making the above mentioned while loop in to a function, then Joe walked me through a for loop that is a lot cleaner than a while loop. Features added: Ability score modifiers.

* 10/19/21 - figured out that rand(#..#) can be used in place of an array and .sample. Removed dice arrays, subbed out rand(). Also figured out 2d arrays and calling from them, as well as a little more about if/else statements with joes help. Features added today: HP based on dice rolls, AC, "+" for positive abil score mods, cleaner code.

10/20/21 - Added a 3d race_array that currently holds the race name, racial ability score bonuses, and move speed. Also added AC and move speed.

10/23/21 - Added another list of characteristics (adjectives) that was snagged from whothefuckismydndcharacter.com to expand. Also added pronoun2 to introduce his, hers, and theirs. Didn't add much recently, I used up a lot of my focus the last day or two on html and css. I should figure out CSVs soon to take care of the ever growing arrays. Did format lists to be verticle and much more readible, although they now take up a lot more verticle space.


=end
#-- Below is the most up to date version. Duplicated versions are used for version control, and dated with the day they were duplicated.


=begin
print "What level should your character be?  "
level = gets.chomp.to_i
#asks the user for their character level

check_true = false
# establishes the check_true variable, needed for the below loop

while check_true == false
  if level < 0
    print "Please pick a number between 1 and 20."
    level = gets.chomp.to_i
  elsif level > 20
    print "Please pick a number between 1 and 20."
    level = gets.chomp.to_i
  else
    check_true = true
  end
end
# this loop and the above functions will be useful eventually for level input, but for now it's a little extra
=end

pronoun = ["he", "she", "they"].sample
# assigns the gender he, she, or they to the variable pronoun, which will later be called to pick names

pronoun2 = ""

if pronoun == "he"
  pronoun2 = "his"
elsif pronoun == "she"
  pronoun2 = "her"
elsif pronoun == "they"
  pronoun2 = "their"
end
# assigns his, her, their depending on the value in pronoun variable

pronoun3 = ""

if pronoun == "he"
  pronoun3 = "him"
elsif pronoun == "she"
  pronoun3 = "her"
elsif pronoun == "they"
  pronoun3 = "them"
end
# assigns him, her, them depending on the value in pronoun variable

isare = ""

if pronoun == "they"
  isare = "are"
else
  isare = "is"
end
# assigns are or is, depending on the pronoun variable


race_number = rand(0..8)
# picks a random number to be used for assigning a race from race_array

race_array = [
  ["dragonborn", [2, 0, 0, 0, 0, 1], 30], 
  ["dwarf",[0,0,3,0,0,0], 25], 
  ["elf", [0,2,0,0,0,0], 30], 
  ["gnome", [0,0,0,2,0,0], 25], 
  ["half-elf", [0,0,0,0,0,2], 30], 
  ["halfling", [0,2,0,0,0,0], 25], 
  ["half-orc", [2,0,1,0,0,0], 30], 
  ["human", [1,1,1,1,1,1], 30], 
  ["tiefling", [0,0,0,1,0,2], 30]]
# the 3d race array from which a race is picked. Currently includes race name, a ability bonus array, and move speed. half-elves also get 1 extra in two different abilities, not sure how to do that within the array.

char_race = race_array[race_number][0]
# samples a race from the race_array

def stat_roll

  six_sided_die = [1,2,3,4,5,6]
roll_four = Array.new

  for i in 0..3
    roll_four << rand(1..6)
  end
  #replace the while loop referenced above, using a for loop in place of a while + if/else combo loop to achieve the same output - add four integers between 1-6 to the roll_four array
  roll_four.sort!
  roll_four.shift

  return roll_four.sum

end
# creates the 'stat_roll' funtion, which uses a 6-sided dice array to 'roll' 4 dice, then subtracts the lowest and sums the remaining, giving a number that can be used for each stat. Saves hella space.

str = stat_roll + race_array[race_number][1][0]
str_mod = (str-10).div(2).floor

dex = stat_roll + race_array[race_number][1][1]
dex_mod = (dex - 10).div(2).floor

con = stat_roll + race_array[race_number][1][2]
con_mod = (con - 10).div(2).floor

int = stat_roll + race_array[race_number][1][3]
int_mod = (int - 10).div(2).floor

wis = stat_roll + race_array[race_number][1][4]
wis_mod = (wis - 10).div(2).floor

cha = stat_roll + race_array[race_number][1][5]
cha_mod = (cha - 10).div(2).floor

# The above variables do two things. The stat variable (ex. str) calls the function stat_roll, which runs the stat_roll function and assigns a number based on that function. 

first_name_array_hum_mal = [
  "Anlow",
  "Arando",
  "Bram",
  "Cale",
  "Dalkon",
  "Daylen",
  "Dodd",
  "Dungarth",
  "Dyrk",
  "Eandro",
  "Falken",
  "Feck",
  "Fenton",
  "Gryphero",
  "Hagar",
  "Jeras",
  "Krynt",
  "Lavant",
  "Leyten",
  "Madian",
  "Malfier",
  "Markus",
  "Meklan",
  "Namen",
  "Navaren",
  "Nerle",
  "Nilus",
  "Ningyan",
  "Norris",
  "Quentin",
  "Semil",
  "Sevenson",
  "Steveren",
  "Talfen",
  "Tamond",
  "Taran",
  "Tavon",
  "Tegan",
  "Vanan",
  "Vincent"
]
# the name array from which a human male name is picked

first_name_hum_mal = first_name_array_hum_mal.sample
# samples a name from first_name_array_hum_mal, because I can't figure out how to combine multiple arrays and then sample them.

first_name_array_hum_fem = [
  "Azura",
  "Brey",
  "Hallan",
  "Kasaki",
  "Lorelei",
  "Mirabel",
  "Pharana",
  "Remora",
  "Rosalyn",
  "Sachil",
  "Saidi",
  "Tanika",
  "Tura",
  "Tylsa",
  "Vencia",
  "Xandrilla"
]
# the name array from which a human female name is picked

first_name_hum_fem = first_name_array_hum_fem.sample
# samples a name from first_name_array_hum_fem

if pronoun == "they"
  first_name = first_name_hum_mal or first_name_hum_fem
elsif pronoun == "he" 
  first_name = first_name_hum_fem
elsif pronoun == "she"
  first_name = first_name_hum_mal
end
# determines if first name needs to be pulled from the male array, female array, or both.

last_name_array_hum = [
  "Arkalis",
  "Armanci",
  "Bilger",
  "Blackstrand",
  "Brightwater",
  "Carnavon",
  "Caskajaro",
  "Coldshore",
  "Coyle",
  "Cresthill",
  "Cuttlescar",
  "Daargen",
  "Dalicarlia",
  "Danamark",
  "Donoghan",
  "Drumwind",
  "Dunhall",
  "Ereghast",
  "Falck",
  "Fallenbridge",
  "Faringray",
  "Fletcher",
  "Fryft",
  "Goldrudder",
  "Grantham",
  "Graylock",
  "Gullscream",
  "Hindergrass",
  "Iscalon",
  "Kreel",
  "Kroft",
  "Lamoth",
  "Leerstrom",
  "Lynchfield",
  "Moonridge",
  "Netheridge",
  "Oakenheart",
  "Pyncion",
  "Ratley",
  "Redraven",
  "Revenmar",
  "Roxley",
  "Sell",
  "Seratolva",
  "Shanks",
  "Shattermast",
  "Shaulfer",
  "Silvergraft",
  "Stavenger",
  "Stormchapel",
  "Strong",
  "Swiller",
  "Talandro" ,
  "Targana",
  "Towerfall",
  "Umbermoor",
  "Van Devries",
  "Van Gandt",
  "Van Hyden",
  "Varcona",
  "Varzand",
  "Voortham",
  "Vrye",
  "Webb",
  "Welfer",
  "Wilxes",
  "Wintermere",
  "Wygarthe",
  "Zatchet",
  "Zethergyll"
]
# the name array from which a human last name is picked 

last_name = last_name_array_hum.sample
# samples a last name from the last_name_array

level = rand(1..20)
# randomly assigns a number between 1 and 20 to the variable level

class_array = [
  ["artificer", 8],
  ["barbarian",12],
  ["bard",8],
  ["cleric",8],
  ["druid",8],
  ["fighter",10],
  ["monk",8],
  ["paladin",10],
  ["ranger",10],
  ["rogue",8],
  ["sorcerer",6],
  ["warlock",8],
  ["wizard",6]
]
# 2d array that contains all the avialable classes, in individual arrays that also contain the hit die value for that class. Currently used by char_class, first_level_hitpoints, and hit_dice.

class_number = rand(0..12)
# picks a random array from class_array

char_class = class_array[class_number][0]
# samples a class from the class_array

first_level_hitpoints = class_array[class_number][1] + con_mod
# pulls the base HP from class_array and adds the con mod, giving you the first level hp which is always the highest number.

hit_dice = class_array[class_number][1]
# uses the number picked by class_number to grab the HP number that correlates with char_class from class_array.

hitpoints = 0
# establishes hitpoints as a variable with a value of 0

for i in (1..level)
  hitpoints += rand(1..hit_dice) + con_mod
end
# runs a for loop to add a set of random numbers + con_mod, the amount of times based on the level variable, the range for the random number based on the hit_dice variable. Starts at 1 instead of 0 so the first level is left out, since that level will be the max dice value + con_mod. This is added in later.

total_hitpoints = hitpoints + first_level_hitpoints
# establishes the total hitpoints, based on the hitpoints variable plus first_level_hitpoints

race_array_plur = [
  "dragonborn",
  "dwarves",
  "elves",
  "gnomes",
  "half-elves",
  "halflings",
  "half-orcs",
  "humans",
  "tieflings"
]
# the race plural array from which a plural race is picked

race_plural = race_array_plur.sample
# samples a race from race_array_plur

align_array = [
  "lawful good",
  "nuetral good",
  "chaotic good",
  "lawful nuetral",
  "true nuetral",
  "chaotic nuetral",
  "lawful evil",
  "nuetral evil",
  "chaotic evil",
]
# the alignment array from which an alignment is picked

alignment = align_array.sample
# samples an alignment from align_array

characteristic_array = [
  "a big grouch",
  "very friendly",
  "pretty shy",
  "talkative",
  "a religious zealot",
  "not a fan of fish",
  "an orphan",
  "an idiot",
  "supremely aware of #{pronoun2} lack in the romance department",
]
# array of random characteristics

= begin
require 'csv'
characteristic_array2 = []
characteristic_array2 = CSV.read('adjectives.csv')
characteristic_array2.shift()
= end
#reads the adjectives.csv file to the characteristics_array2 variable. Doesn't seem to work the way I want. When called later on, it prints the whole array. 

characteristic_array2 = [
  "bigoted",
  "bitchy",
  "blunt",
  "boisterous",
  "bossy",
  "brave",
  "callous",
  "cautious",
  "charming",
  "cheerful",
  "churlish",
  "cold",
  "composed",
  "conceited",
  "condescending",
  "confident",
  "conscientious",
  "cool-headed",
  "courageous",
  "crabby",
  "crass",
  "critical",
  "cruel",
  "cunning",
  "curious",
  "cynical",
  "decisive",
  "dependable",
  "determined",
  "driven",
  "fearless",
  "flamboyant",
  "flirtatious",
  "friendly",
  "gruff",
  "headstrong",
  "hot-headed",
  "lazy",
  "loud",
  "Machiavellian",
  "moody",
  "philosophical",
  "pompous",
  "pretty chill",
  "romantic",
  "selfish",
  "sensitive",
  "tactless",
  "thoughtful",
  "wary",
  "depressed",
  "delightful",
  "demure",
  "diligent",
  "disruptive",
  "discerning",
  "dramatic",
  "dutiful",
  "frank",
  "funny",
  "fussy",
  "generous",
  "gentle",
  "gloomy",
  "grave",
  "grouchy",
  "guarded",
  "hateful",
  "helpful",
  "hot-headed",
  "hypercritical",
  "level-headed",
  "mean",
  "methodical",
  "meticulous",
  "miserable",
  "motivated",
  "morose",
  "naive",
  "nosy",
  "peaceful",
  "pensive",
  "plain-speaking",
  "playful",
  "plucky",
  "positive",
  "proud",
  "prejudiced",
  "quick-tempered",
  "reliable",
  "reluctant",
  "resentful",
  "resourceful",
  "respectful",
  "restless",
  "sassy",
  "sentimental",
  "short-tempered",
  "snobby",
  "sombre",
  "sophisticated",
  "spiteful",
  "soulless",
  "stern",
  "stoic",
  "surly",
  "sweet",
  "suspicious",
  "talented",
  "warm-hearted",
  "wary",
  "well-intentioned",
  "adventurous",
  "agreeable",
  "ambitious",
  "anxious",
  "apathetic",
  "argumentative",
  "assertive",
  "attentive",
  "impulsive",
  "intolerant",
  "inventive",
  "overemotional",
  "unpredictable",
  "eager",
  "easy-going",
  "egotistical",
  "emotional",
  "enterprising",
  "enthusiastic",
  "excitable",
  "impatient",
  "impetuous",
  "inconsiderate",
  "insensitive",
  "irritable",
  "obnoxious",
  "old-fashioned",
  "outgoing",
  "outspoken",
  "unbalanced",
  "unstable",
  "absent minded",
  "melodramatic",
  "paranoid",
  "chipper",
  "passive-aggressive",
  "amicable",
  "broad-minded",
  "compassionate",
  "considerate",
  "diplomatic",
  "faithful",
  "hard-working",
  "modest",
]
# (list taken from whothefuckismydndcharacter.com to save time while proofing. Be careful if publishing to remove this list and use only own work.)second array of random characteristics



all_char = characteristic_array + characteristic_array2

char_1 = all_char.sample
all_char.delete(char_1)
# picks a characteristic from characteristic_array

char_2 = all_char.sample
# picks a second characteristic from characteristic_array

armor_class = 10 + dex_mod

move_speed = race_array[race_number][2]

prof_bonus = 2

if level <= 4
  prof_bonus += 0
elsif level <= 8
  prof_bonus += 1
elsif level <= 12
  prof_bonus += 2
elsif level <= 16
  prof_bonus += 3
elsif level <= 20
  prof_bonus += 4
end
#  proficiency bonus loop. prof_bonus is established at a baseline of 2, the lowest it can be. Looks at level int and adds to prof_bonus depending on the level.


# plus = if wis_mod > 0 then "+" else "" end
# if/then/else argument to add a + or not. Replaced by "+" if wis_mod > 0, which is cleaner
# used in the ability score modifier section to include a + if the number is above 0. 




#---   print section   ---#

print "Your character is #{first_name} #{last_name}, a level #{level} #{char_race.capitalize} #{char_class.capitalize}.\n#{first_name} has an alignment of #{alignment}, and really #{["likes", "hates"].sample} #{race_plural}. \n#{pronoun.capitalize} #{isare} #{char_1} and #{char_2}."
print"\n"
print"\n"

print "#{first_name}'s ability scores are:"
print "\n#{str} Strength (#{"+" if str_mod > 0}#{str_mod})"
print "\n#{dex} Dexterity (#{"+" if dex_mod > 0}#{dex_mod})"
print "\n#{con} Constitution (#{"+" if con_mod > 0}#{con_mod})"
print "\n#{int} Intelligence (#{"+" if int_mod > 0}#{int_mod})"
print "\n#{wis} Wisdom (#{"+" if wis_mod > 0}#{wis_mod})"
print "\n#{cha} Charisma (#{"+" if cha_mod > 0}#{cha_mod})"
print "\n"
print "\n"

print "#{first_name} has #{total_hitpoints} hitpoints and an AC of #{armor_class}"

print "\n#{pronoun.capitalize} can move #{move_speed} feet per round."

print "\n#{pronoun2.capitalize} proficiency bonus is +#{prof_bonus}."

# the user facing part of the code. Takes all of the variables defined above and slaps together some sort of character.


print "\n"


#-- */









/*

PYTHON CODE

""""
10/14/21 - This is the second version of my random character creator for DND. The first version prooved the basic system and taught me some stuff about arrays, sampling, and checking those samples. This version will adjust the system to be more fluid, and flesh out the name arrays. After that is built out more thoroughly I'll move on to back stories and more fleshing out of characters. Once that is solid I will move on to stat blocks. If I'm still working on this by then I'll figure out how to export to a txt file and eventually a writable character sheet pdf.

I worked out with josh how to make use a while loop to ask the user what their level is, and re-ask if they enter a number outside the accepted range, then move forward if an acceptable number is given. Not useful this early on, but will be when stats come in to play.

10/17/21 - Figured out a while loop to roll four 6 sided die, subtract the lowest number, and sum them, fulfilling the classic method of stat determination. Features added: Ability score #s based on dice rolls.

10/18/21 - Figured out making the above mentioned while loop in to a function, then Joe walked me through a for loop that is a lot cleaner than a while loop. Features added: Ability score modifiers.

* 10/19/21 - figured out that rand(#..#) can be used in place of an array and .sample. Removed dice arrays, subbed out rand(). Also figured out 2d arrays and calling from them, as well as a little more about if/else statements with joes help. Features added today: HP based on dice rolls, AC, "+" for positive abil score mods, cleaner code.

10/20/21 - Added a 3d race_array that currently holds the race name, racial ability score bonuses, and move speed. Also added AC and move speed.

10/23/21 - Added another list of characteristics (adjectives) that was snagged from whothefuckismydndcharacter.com to expand. Also added pronoun2 to introduce his, hers, and theirs. Didn't add much recently, I used up a lot of my focus the last day or two on html and css. I should figure out CSVs soon to take care of the ever growing arrays. Did format lists to be verticle and much more readible, although they now take up a lot more verticle space.


NEW NEW NEW NEW

1/12/22 - Learning Python, and instead of rewriting the whole random charater generator that I created in Ruby, I decided I'd just convert it from Ruby to Python 3 as a learning exercise. Once that's done I'll build something from scratch, but this will allow me to learn the proper Python format/syntax/vocab for systems I already have an understanding of in Ruby. I'll probably do the same thing in Javascript, then eventually use JSON, HTML, and CSS to put the JS version up on a website like I'd originally intended with Ruby.


"""
#-- Below is the most up to date version. Duplicated versions are used for version control, and dated with the day they were duplicated.


""""
print "What level should your character be?  "
level = gets.chomp.to_i
#asks the user for their character level

check_true = false
# establishes the check_true variable, needed for the below loop

while check_true == false
  if level < 0
    print "Please pick a number between 1 and 20."
    level = gets.chomp.to_i
  elsif level > 20
    print "Please pick a number between 1 and 20."
    level = gets.chomp.to_i
  else
    check_true = true
  end
end
# this loop and the above functions will be useful eventually for level input, but for now it's a little extra
"""
import random
#imports the random module for later use
pronouns = ["he", "she", "they"]
pronoun = random.choice(pronouns) 
# assigns the gender he, she, or they to the variable pronoun, which will later be called to pick names

pronoun2 = ""

if pronoun == "he":
  pronoun2 = "his"
elif pronoun == "she":
  pronoun2 = "her"
elif pronoun == "they":
  pronoun2 = "their"
# assigns his, her, their depending on the value in pronoun variable

pronoun3 = ""

if pronoun == "he":
  pronoun3 = "him"
elif pronoun == "she":
  pronoun3 = "her"
elif pronoun == "they":
  pronoun3 = "them"
# assigns him, her, them depending on the value in pronoun variable

isare = ""

if pronoun == "they":
  isare = "are"
else:
  isare = "is"
# assigns are or is, depending on the pronoun variable


race_number = random.randrange(0,8)
# picks a random number to be used for assigning a race from race_array

race_array = [
  ["dragonborn", [2,0,0,0,0,1], 30], 
  ["dwarf",[0,0,3,0,0,0], 25], 
  ["elf", [0,2,0,0,0,0], 30], 
  ["gnome", [0,0,0,2,0,0], 25], 
  ["half-elf", [0,0,0,0,0,2], 30], 
  ["halfling", [0,2,0,0,0,0], 25], 
  ["half-orc", [2,0,1,0,0,0], 30], 
  ["human", [1,1,1,1,1,1], 30], 
  ["tiefling", [0,0,0,1,0,2], 30]]
# the 3d race array from which a race is picked. Currently includes race name, a ability bonus array, and move speed. half-elves also get 1 extra in two different abilities, not sure how to do that within the array.

char_race = race_array[race_number][0]
# samples a race from the race_array

roll_four = 0

def stat_roll():

  six_sided_die = [1,2,3,4,5,6]

  for i in range(4):
    roll_four << random.randrange(1,6)
  #replace the while loop referenced above, using a for loop in place of a while + if/else combo loop to achieve the same output - add four integers between 1-6 to the roll_four array
  roll_four.sort()
  roll_four.shift()

  return roll_four.sum
# creates the 'stat_roll' funtion, which uses a 6-sided dice array to 'roll' 4 dice, then subtracts the lowest and sums the remaining, giving a number that can be used for each stat. Saves hella space.



st = stat_roll + race_array[race_number][1][0]
str_mod = (st-10).div(2).floor

dex = stat_roll + race_array[race_number][1][1]
dex_mod = (dex-10).div(2).floor

con = stat_roll + race_array[race_number][1][2]
con_mod = (con-10).div(2).floor

inte = stat_roll + race_array[race_number][1][3]
int_mod = (inte-10).div(2).floor

wis = stat_roll + race_array[race_number][1][4]
wis_mod = (wis-10).div(2).floor

cha = stat_roll + race_array[race_number][1][5]
cha_mod = (cha-10).div(2).floor

# The above variables do two things. The stat variable (ex. str) calls the function stat_roll, which runs the stat_roll function and assigns a number based on that function. 

first_name_array_hum_mal = [
  "Anlow", 
  "Arando", 
  "Bram", 
  "Cale", 
  "Dalkon", 
  "Daylen", 
  "Dodd", 
  "Dungarth", 
  "Dyrk", 
  "Eandro", 
  "Falken", 
  "Feck", 
  "Fenton", 
  "Gryphero", 
  "Hagar", 
  "Jeras", 
  "Krynt", 
  "Lavant", 
  "Leyten", 
  "Madian", 
  "Malfier", 
  "Markus", 
  "Meklan", 
  "Namen", 
  "Navaren", 
  "Nerle", 
  "Nilus", 
  "Ningyan", 
  "Norris", 
  "Quentin", 
  "Semil", 
  "Sevenson", 
  "Steveren", 
  "Talfen", 
  "Tamond", 
  "Taran", 
  "Tavon", 
  "Tegan", 
  "Vanan", 
  "Vincent"
]
# the name array from which a human male name is picked

first_name_hum_mal = first_name_array_hum_mal.sample
# samples a name from first_name_array_hum_mal, because I can't figure out how to combine multiple arrays and then sample them.

first_name_array_hum_fem = [
  "Azura", 
  "Brey", 
  "Hallan", 
  "Kasaki", 
  "Lorelei", 
  "Mirabel", 
  "Pharana", 
  "Remora", 
  "Rosalyn", 
  "Sachil", 
  "Saidi", 
  "Tanika", 
  "Tura", 
  "Tylsa", 
  "Vencia", 
  "Xandrilla"
]
# the name array from which a human female name is picked

first_name_hum_fem = first_name_array_hum_fem.sample
# samples a name from first_name_array_hum_fem

if pronoun == "they":
  first_name = first_name_hum_mal or first_name_hum_fem
elif pronoun == "he":
  first_name = first_name_hum_fem
elif pronoun == "she":
  first_name = first_name_hum_mal
end
# determines if first name needs to be pulled from the male array, female array, or both.

last_name_array_hum = [
  "Arkalis", 
  "Armanci", 
  "Bilger", 
  "Blackstrand", 
  "Brightwater", 
  "Carnavon", 
  "Caskajaro", 
  "Coldshore", 
  "Coyle", 
  "Cresthill", 
  "Cuttlescar", 
  "Daargen", 
  "Dalicarlia",
  "Danamark", 
  "Donoghan", 
  "Drumwind", 
  "Dunhall", 
  "Ereghast", 
  "Falck", 
  "Fallenbridge", 
  "Faringray", 
  "Fletcher", 
  "Fryft", 
  "Goldrudder", 
  "Grantham", 
  "Graylock", 
  "Gullscream", 
  "Hindergrass", 
  "Iscalon", 
  "Kreel", 
  "Kroft", 
  "Lamoth", 
  "Leerstrom", 
  "Lynchfield", 
  "Moonridge", 
  "Netheridge", 
  "Oakenheart", 
  "Pyncion", 
  "Ratley", 
  "Redraven", 
  "Revenmar", 
  "Roxley", 
  "Sell", 
  "Seratolva", 
  "Shanks", 
  "Shattermast", 
  "Shaulfer", 
  "Silvergraft", 
  "Stavenger", 
  "Stormchapel", 
  "Strong", 
  "Swiller", 
  "Talandro" , 
  "Targana", 
  "Towerfall", 
  "Umbermoor", 
  "Van Devries",
  "Van Gandt", 
  "Van Hyden", 
  "Varcona", 
  "Varzand", 
  "Voortham", 
  "Vrye", 
  "Webb", 
  "Welfer", 
  "Wilxes", 
  "Wintermere", 
  "Wygarthe", 
  "Zatchet", 
  "Zethergyll"
]
# the name array from which a human last name is picked 

last_name = last_name_array_hum.sample
# samples a last name from the last_name_array

level = random.randrange(1,20)
# randomly assigns a number between 1 and 20 to the variable level

class_array = [
  ["artificer",8],
  ["barbarian",12],
  ["bard",8],
  ["cleric",8],
  ["druid",8],
  ["fighter",10],
  ["monk",8],
  ["paladin",10],
  ["ranger",10],
  ["rogue",8],
  ["sorcerer",6],
  ["warlock",8],
  ["wizard",6]
]
# 2d array that contains all the avialable classes, in individual arrays that also contain the hit die value for that class. Currently used by char_class, first_level_hitpoints, and hit_dice.

class_number = random.randrange(0,12)
# picks a random array from class_array

char_class = class_array[class_number][0]
# samples a class from the class_array

first_level_hitpoints = class_array[class_number][1]+con_mod
# pulls the base HP from class_array and adds the con mod, giving you the first level hp which is always the highest number.

hit_dice = class_array[class_number][1]
# uses the number picked by class_number to grab the HP number that correlates with char_class from class_array.

hitpoints = 0
# establishes hitpoints as a variable with a value of 0

for i in (1..level):
  hitpoints += rand(1..hit_dice)+con_mod
end
# runs a for loop to add a set of random numbers + con_mod, the amount of times based on the level variable, the range for the random number based on the hit_dice variable. Starts at 1 instead of 0 so the first level is left out, since that level will be the max dice value + con_mod. This is added in later.

total_hitpoints = hitpoints+first_level_hitpoints
# establishes the total hitpoints, based on the hitpoints variable plus first_level_hitpoints

race_array_plur = [
  "dragonborn", 
  "dwarves", 
  "elves", 
  "gnomes", 
  "half-elves", 
  "halflings", 
  "half-orcs", 
  "humans", 
  "tieflings"
]
# the race plural array from which a plural race is picked

race_plural = race_array_plur.sample
# samples a race from race_array_plur

align_array = [
  "lawful good", 
  "nuetral good", 
  "chaotic good", 
  "lawful nuetral", 
  "true nuetral", 
  "chaotic nuetral", 
  "lawful evil", 
  "nuetral evil", 
  "chaotic evil",
]
# the alignment array from which an alignment is picked

alignment = align_array.sample
# samples an alignment from align_array

characteristic_array = [
  "a big grouch", 
  "very friendly", 
  "pretty shy", 
  "talkative", 
  "a religious zealot", 
  "not a fan of fish", 
  "an orphan", 
  "an idiot",
  "supremely aware of #{pronoun2} lack in the romance department",
]
# array of random characteristics

""""
require 'csv'
characteristic_array2 = []
characteristic_array2 = CSV.read('adjectives.csv')
characteristic_array2.shift()
"""
#reads the adjectives.csv file to the characteristics_array2 variable. Doesn't seem to work the way I want. When called later on, it prints the whole array. 

characteristic_array2 = [
  "bigoted",
  "bitchy",
  "blunt",
  "boisterous",
  "bossy",
  "brave",
  "callous",
  "cautious",
  "charming",
  "cheerful",
  "churlish",
  "cold",
  "composed",
  "conceited",
  "condescending",
  "confident",
  "conscientious",
  "cool-headed",
  "courageous",
  "crabby",
  "crass",
  "critical",
  "cruel",
  "cunning",
  "curious",
  "cynical",
  "decisive",
  "dependable",
  "determined",
  "driven",
  "fearless",
  "flamboyant",
  "flirtatious",
  "friendly",
  "gruff",
  "headstrong",
  "hot-headed",
  "lazy",
  "loud",
  "Machiavellian",
  "moody",
  "philosophical",
  "pompous",
  "pretty chill",
  "romantic",
  "selfish",
  "sensitive",
  "tactless",
  "thoughtful",
  "wary",
  "depressed",
  "delightful",
  "demure",
  "diligent",
  "disruptive",
  "discerning",
  "dramatic",
  "dutiful",
  "frank",
  "funny",
  "fussy",
  "generous",
  "gentle",
  "gloomy",
  "grave",
  "grouchy",
  "guarded",
  "hateful",
  "helpful",
  "hot-headed",
  "hypercritical",
  "level-headed",
  "mean",
  "methodical",
  "meticulous",
  "miserable",
  "motivated",
  "morose",
  "naive",
  "nosy",
  "peaceful",
  "pensive",
  "plain-speaking",
  "playful",
  "plucky",
  "positive",
  "proud",
  "prejudiced",
  "quick-tempered",
  "reliable",
  "reluctant",
  "resentful",
  "resourceful",
  "respectful",
  "restless",
  "sassy",
  "sentimental",
  "short-tempered",
  "snobby",
  "sombre",
  "sophisticated",
  "spiteful",
  "soulless",
  "stern",
  "stoic",
  "surly",
  "sweet",
  "suspicious",
  "talented",
  "warm-hearted",
  "wary",
  "well-intentioned",
  "adventurous",
  "agreeable",
  "ambitious",
  "anxious",
  "apathetic",
  "argumentative",
  "assertive",
  "attentive",
  "impulsive",
  "intolerant",
  "inventive",
  "overemotional",
  "unpredictable",
  "eager",
  "easy-going",
  "egotistical",
  "emotional",
  "enterprising",
  "enthusiastic",
  "excitable",
  "impatient",
  "impetuous",
  "inconsiderate",
  "insensitive",
  "irritable",
  "obnoxious",
  "old-fashioned",
  "outgoing",
  "outspoken",
  "unbalanced",
  "unstable",
  "absent minded",
  "melodramatic",
  "paranoid",
  "chipper",
  "passive-aggressive",
  "amicable",
  "broad-minded",
  "compassionate",
  "considerate",
  "diplomatic",
  "faithful",
  "hard-working",
  "modest",
]
# (list taken from whothefuckismydndcharacter.com to save time while proofing. Be careful if publishing to remove this list and use only own work.)second array of random characteristics



all_char = characteristic_array+characteristic_array2

char_1 = all_char.sample
all_char.delete(char_1)
# picks a characteristic from characteristic_array

char_2 = all_char.sample
# picks a second characteristic from characteristic_array

armor_class = 10+dex_mod

move_speed = race_array[race_number][2]

prof_bonus = 2

if level <= 4:
  prof_bonus += 0
elif level <= 8:
  prof_bonus += 1
elif level <= 12:
  prof_bonus += 2
elif level <= 16:
  prof_bonus += 3
elif level <= 20:
  prof_bonus += 4
end
#  proficiency bonus loop. prof_bonus is established at a baseline of 2, the lowest it can be. Looks at level int and adds to prof_bonus depending on the level.


# plus = if wis_mod > 0 then "+" else "" end
# if/then/else argument to add a + or not. Replaced by "+" if wis_mod > 0, which is cleaner
# used in the ability score modifier section to include a + if the number is above 0. 




#---   print section   ---#

print("Your character is %s %s, a level " + str(level) + char_race.capitalize() + " " + char_class.capitalize()
)  % (first_name, last_name)

print("\n")

print("%s has an alignment of %s, and really " + random.choice("likes", "hates") + " %s.") % (first_name, alignment, race_plural)

print("\n")

print(pronoun.capitalize() + " %s %s and %s.") % (isare, char_1, char_2)

print("\n")
print("\n")

print (" %s\'s ability scores are:") % (first_name)
print ("\n " + str(st) + " Strength (%s)") % (str_mod)

print ("\n " + str(dex) + " Dexterity (%s)") % (dex_mod)

print ("\n " + str(con) + " Constitution (%s)") % (con_mod)

print ("\n " + str(inte) + " Intelligence (%s)") % (int_mod)

print ("\n " + str(wis) + " Wisdom (%s)") % (wis_mod)

print ("\n " + str(cha) + " Charisma (%s)") % (cha_mod)

print ("\n")
print ("\n")

print ("%s has %d hitpoints and an AC of %d") % (first_name, total_hitpoints, armor_class)

print ("\n" + pronoun.capitalize() + " can move %d feet per round.") % (move_speed)

print ("\n" + pronoun2.capitalize() + " proficiency bonus is + %d.") % (prof_bonus)

# the user facing part of the code. Takes all of the variables defined above and slaps together some sort of character.


print ("\n")


#--
*/



using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] pronoun = { "he", "she", "they" };
            // assigns the gender he, she, or they to the variable pronoun, which will later be called to pick names
            string randomPronoun = StringRandomizer(pronoun);
            string pronoun2;

            if (randomPronoun.Contains("they"))
            {
                pronoun2 = "their";
            }
            else if (randomPronoun.Contains("she"))
            {
                pronoun2 = "her";
            }
            else
            {
                pronoun2 = "his";
            }
            // assigns his, her, their depending on the value in pronoun variable

            string pronoun3;

            if (randomPronoun.Contains("they"))
            {
                pronoun3 = "them";
            }
            else if (randomPronoun.Contains("she"))
            {
                pronoun3 = "her";
            }
            else
            {
                pronoun3 = "him";
            }
            // assigns him, her, them depending on the value in pronoun variable

            string isare;

            if (randomPronoun.Contains("they"))
            {
                isare = "are";
            }
            else
            {
                isare = "is";
            }
            // assigns are or is, depending on the pronoun variable

            int raceNumber = NumberRandomizer(0, 10);
            // picks a number at random for use assigning a race from raceArray.
  
            string[] raceArray = { "dragonborn", "dwarf", "elf", "gnome", "half-elf", "halfling", "half-orc", "human", "tiefling" };
            int[,] raceStatArray = new int[,] {
                //dragonborn
                {2,0,0,0,0,1,30},
                //dwarf
                {0,0,3,0,0,0,25},
                //elf
                {0,2,0,0,0,0,30},
                //gnome
                {0,0,0,2,0,0,25},
                //half-elf
                {0,0,0,0,0,2,30},
                //halfling
                {0,2,0,0,0,0,25},
                //half-orc
                {2,0,1,0,0,0,30},
                //human
                {1,1,1,1,1,1,30},
                //tiefling
                {0,0,0,1,0,2,30}
            };
            // creates the stat block for each race, referenced heavily below;

            int statRoll = DiceRoll(1, 7);

            string charRace = raceArray[raceNumber];
            int str = statRoll + raceStatArray[raceNumber, 0];
            double strMath = (str - 10) / 2;
            double strMod = Math.Floor(strMath);
            int dex = statRoll + raceStatArray[raceNumber, 1];
            double dexMath = (dex - 10) / 2;
            double dexMod = Math.Floor(dexMath);
            int con = statRoll + raceStatArray[raceNumber, 2];
            double conMath = (con - 10) / 2;
            double conMod = Math.Floor(conMath);
            int intel = statRoll + raceStatArray[raceNumber, 3];
            double intelMath = (intel - 10) / 2;
            double intelMod = Math.Floor(intelMath);
            int wis = statRoll + raceStatArray[raceNumber, 4];
            double wisMath = (wis - 10) / 2;
            double wisMod = Math.Floor(wisMath);
            int cha = statRoll + raceStatArray[raceNumber, 5];
            double chaMath = (cha - 10) / 2;
            double chaMod = Math.Floor(chaMath);



            string[] firstNameArrayHumMal = {
              "Anlow",
              "Arando",
              "Bram",
              "Cale",
              "Dalkon",
              "Daylen",
              "Dodd",
              "Dungarth",
              "Dyrk",
              "Eandro",
              "Falken",
              "Feck",
              "Fenton",
              "Gryphero",
              "Hagar",
              "Jeras",
              "Krynt",
              "Lavant",
              "Leyten",
              "Madian",
              "Malfier",
              "Markus",
              "Meklan",
              "Namen",
              "Navaren",
              "Nerle",
              "Nilus",
              "Ningyan",
              "Norris",
              "Quentin",
              "Semil",
              "Sevenson",
              "Steveren",
              "Talfen",
              "Tamond",
              "Taran",
              "Tavon",
              "Tegan",
              "Vanan",
              "Vincent"
            };
            // the name array from which a human male name is picked

            string firstNameHumMal = StringRandomizer(firstNameArrayHumMal);
            // samples a name from firstNameArrayHumMal, because I can't figure out how to combine multiple arrays and then sample them.

            string[] firstNameArrayHumFem = {
            "Azura",
            "Brey",
            "Hallan",
            "Kasaki",
            "Lorelei",
            "Mirabel",
            "Pharana",
            "Remora",
            "Rosalyn",
            "Sachil",
            "Saidi",
            "Tanika",
            "Tura",
            "Tylsa",
            "Vencia",
            "Xandrilla"
            };
            //the name array from which a human female name is picked

            string firstNameHumFem = StringRandomizer(firstNameArrayHumFem);
            //samples a name from first_name_array_hum_fem

            string firstName;
            string[] bothFirstNames = { firstNameHumFem, firstNameHumMal };
            if (randomPronoun.Contains("they"))
            { 
                firstName = StringRandomizer(bothFirstNames); 
            } 
            else if (randomPronoun.Contains("she"))
            {
                firstName = firstNameHumFem;
            }              
            else
            {
                firstName = firstNameHumMal;
            }
            //determines if first name needs to be pulled from the male array, female array, or both.

            string[] lastNameArrayHum = {
            "Arkalis",
            "Armanci",
            "Bilger",
            "Blackstrand",
            "Brightwater",
            "Carnavon",
            "Caskajaro",
            "Coldshore",
            "Coyle",
            "Cresthill",
            "Cuttlescar",
            "Daargen",
            "Dalicarlia",
            "Danamark",
            "Donoghan",
            "Drumwind",
            "Dunhall",
            "Ereghast",
            "Falck",
            "Fallenbridge",
            "Faringray",
            "Fletcher",
            "Fryft",
            "Goldrudder",
            "Grantham",
            "Graylock",
            "Gullscream",
            "Hindergrass",
            "Iscalon",
            "Kreel",
            "Kroft",
            "Lamoth",
            "Leerstrom",
            "Lynchfield",
            "Moonridge",
            "Netheridge",
            "Oakenheart",
            "Pyncion",
            "Ratley",
            "Redraven",
            "Revenmar",
            "Roxley",
            "Sell",
            "Seratolva",
            "Shanks",
            "Shattermast",
            "Shaulfer",
            "Silvergraft",
            "Stavenger",
            "Stormchapel",
            "Strong",
            "Swiller",
            "Talandro",
            "Targana",
            "Towerfall",
            "Umbermoor",
            "Van Devries",
            "Van Gandt",
            "Van Hyden",
            "Varcona",
            "Varzand",
            "Voortham",
            "Vrye",
            "Webb",
            "Welfer",
            "Wilxes",
            "Wintermere",
            "Wygarthe",
            "Zatchet",
            "Zethergyll"
            };
            // the name array from which a human last name is picked 

            string lastName = StringRandomizer(lastNameArrayHum);
            //samples a last name from the last_name_array


            Console.WriteLine(pronoun3);
            Console.WriteLine(randomPronoun);
            Console.WriteLine(pronoun2);
            Console.WriteLine(raceNumber);
            Console.WriteLine(statRoll);
            Console.WriteLine($"{charRace}, {str}, {strMod}, {dex}, {dexMod}, {chaMod}");

            Console.WriteLine($"{firstName} {lastName}");
                        


        }
        public static string StringRandomizer(string[] arrayToRandomize)
        {
            Random rand = new Random();

            int index = rand.Next(arrayToRandomize.Length);

            return arrayToRandomize[index];

            //picks a string at random from the input string array. Used to pick things like pronouns, adjectives, etc at random

        }
        public static int NumberRandomizer(int numToRandomize1, int numToRandomize2)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(numToRandomize1, numToRandomize2);

            return randomNumber;

            //picks an interger at random from a provided range.
        }
        public static int DiceRoll(int bottomOfRange, int topOfRange)
        {

		Random rnd = new Random();
        List<int> diceRolls = new List<int>();
        for (int i = 0; i<4; i++)
            //rolls picks 4 ("i<4") numbers at random based on the int range in the following ".Next(int, int)"
            {
                diceRolls.Add(rnd.Next(bottomOfRange,topOfRange));
            }
            diceRolls.Sort();
            diceRolls.RemoveAt(0);
            return diceRolls.Sum();
        }
        
        
    }
}
    
    
    

     


