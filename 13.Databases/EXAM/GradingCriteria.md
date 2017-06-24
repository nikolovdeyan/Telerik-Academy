# Task 1

- Are all superheroes listed?
    * Yes (2)
    * No (0)
    * Not implemented (0)

- How is the query implemented?
    * With 2 inner joins and a where clause (2)
    * With less than 2 joins, but still works (1)
    * Without any joins
    * Not implemented (0)

- The result table has only columns 'Id' and 'Name'?
    * Yes (2)
    * No (0)
    * Not implemented (0)
 
# Task 2

- All superheroes are listed with their powers and power types?
    * Yes (2)
    * No (0)
    * Not implemented (0)

- How is the query implemented?
    * With 3 inner joins (2)
    * With less than 3 joins, but still works (1)
    * Not implemented (0)

- The result table has only columns 'Superhero' and 'Power'?
    * Yes (2)
    * No (0)
    * Not implemented (0)

- The column 'Power' includes its power type?
    * Yes (2)
    * No (0)
    * Not implemented (0)

# Task 3

- The correct planets are listed:
    * Yes (2)
    * No (0)
    * Not implemented (0)

- Are the planets sorted in the correct order?
    * Yes (2)
    * No (0)
    * Not implemented (0)

- The superheroes are counted correctly, only the ones with 'Good' alignment
    * Yes (2)
    * No (0)
    * Not implemented (0)

- How is the query implemented?
    * With 3 inner joins (2)
    * With less than 3 joins, but still works (1)
    * Not implemented (0)

- The result table has only columns 'Planet' and 'Protectors'?
    * Yes (2)
    * No (0)
    * Not implemented (0)

# Task 4

- The stored procedure for editing Superhero's Bio is implemented
    * Yes (2)
    * No (0)

- The stored procedure for editing Superhero's Bio is named usp_UpdateSuperheroBio
    * Yes (2)
    * No (0)
    * Not implemented (0)

# Task 5

- The stored procedure for listing full info about superheroes works
    * Yes (2)
    * No (0)
    * Not implemented (0)

- The stored procedure for listing full info about superheroes is named usp_GetSuperheroInfo
    * Yes (2)
    * No (0)
    * Not implemented (0)


- usp_GetSuperheroInfo is implemented:
    * With 6+ inner join (2)
    * With less than 6 joins, but still works (1)
    * Not implemented (0)

- usp_GetSuperheroInfo contains repeating column values in multiple rows (i.e. Groot protects both 'Earth' and 'The Galaxy' and should has atleast two rows for that)
    * Yes (3)
    * No (0)
    * Not implemented (0)

- The result table of usp_GetSuperheroInfo contains only colums with names 'Id', 'Name', 'Secret Identity', 'Bio', 'Alignment', 'Planet' and 'Power' ?
    * Yes (2)
    * No (0)
    * Not implemented (0)

# Task 6

- The stored procedure for printing the number of heroes with Good, Evil and Neutral alignment for each Planet works:
    * Yes (2)
    * No (0)

- The stored procedure for printing the number of heroes with Good, Evil and Neutral alignment for each Planet is named 'usp_GetPlanetsWithHeroesCount':
    * Yes (2)
    * No (0)
    * Not implemented (0)

- usp_GetPlanetsWithHeroesCount is returning correct result:
    * Yes (2)
    * No (0)
    * Not implemented (0)

- usp_GetPlanetsWithHeroesCount is implemented:
    * With 3+ inner join (2)
    * With less than 3 joins, but still works (1)
    * Not implemented (0)

- The result table of usp_GetPlanetsWithHeroesCount has only colums with names 'Planet', 'Good heroes', 'Neutral heroes', 'Evil heroes':
    * Yes (2)
    * No (0)
    * Not implemented (0)

# Task 7

- The stored procedure for creating a Superhero, with provided name, secret identity, bio, alignment, a planet and 3 powers (with their types) works:
    * Yes (6)
    * Partially (2)
    * No (0)
    * Not implemented (0)

- The stored procedure for creating a Superhero, with provided name, secret identity, bio, alignment, a planet and 3 powers (with their types) reuses:
    * All of powers, power types, planets and alignments (6) 
    * Some of powers, power types, planets and alignments (2)
    * None of powers, power types, planets and alignments (0) 
    * Not implemented (0)

# Task 8

- The stored procedure for printing the number of powers by alignment of their superheroes works:
    * Yes (2)
    * No (0)
    * Not implemented (0)

- The stored procedure for printing the number of powers by alignment of their superheroes is named usp_PowersUsageByAlignment:
    * Yes (4)
    * No (0)
    * Not implemented (0)

- usp_PowersUsageByAlignment returns correct result:
    * Yes (8)
    * No (0)
    * Not implemented (0)

- The result table of usp_PowersUsageByAlignment has only colums with names 'Alignment' and 'Powers Count':
    * Yes (2)
    * No (0)
    * Not implemented (0)