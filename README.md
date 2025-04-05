# Cookie Cookbook

This project was completed as part of a Udemy Course:
- **Ultimate C# Masterclass for 2025** by **Krystyna Ślusarczyk**

The tutor provides project requirements and encourages students to build the solution independently before reviewing the tutor's solution.

This solution contains the following two projects:
- `CookieCookbook` (Built by me before viewing the tutor's solution)
- `CookieCookbookTutorSolution` (Tutor's solution)

---

## 🛠 Built With
- C# Console Application

---

## 📜 Overview

The **Cookie Cookbook** application allows the user to create and save cookie recipes by selecting ingredients from a list. Each recipe consists of a collection of ingredients, and once created, the recipe is saved either in a `.txt` or `.json` format, based on the setting defined in the program.

---

## 🧑‍🍳 Glossary

- **Ingredient**: Represents a single ingredient that can be included in a recipe, such as Wheat Flour or Sugar. Each ingredient has an ID, a name, and a string with instructions on preparing it.
  
- **Recipe**: A collection of ingredients, for example, a simple recipe could include Wheat Flour, Butter, and Sugar.

---

## ▶️ Main Application Workflow

1. **Starting the Application:**
   - If recipes already exist in the saved file, they are loaded and displayed on the console.
     ```
     Existing recipes are:
     *****1*****
     Wheat flour. Sieve. Add to other ingredients.
     Coconut flour. Sieve. Add to other ingredients.
     Butter. Melt on low heat. Add to other ingredients.
     *****2*****
     Butter. Melt on low heat. Add to other ingredients.
     Chocolate. Melt in a water bath. Add to other ingredients.
     Sugar. Add to other ingredients.
     ```
   - After showing existing recipes, the user is prompted to create a new recipe:
     ```
     Create a new cookie recipe! Available ingredients are:
     1. Wheat flour
     2. Coconut flour
     3. Butter
     4. Chocolate
     5. Sugar
     6. Cardamom
     7. Cinnamon
     8. Cocoa powder
     ```
   
2. **Selecting Ingredients for the New Recipe:**
   - The user selects ingredients by entering their ID number. They can select multiple ingredients, or stop the process by entering a non-numeric input.
     ```
     Add an ingredient by its ID or type anything else if finished.
     ```
   - If the user has selected at least one ingredient, the recipe is saved to the file.
     ```
     Recipe added:
     Wheat flour. Sieve. Add to other ingredients.
     Sugar. Add to other ingredients.
     Butter. Melt on low heat. Add to other ingredients.
     ```
   - If no ingredients are selected, the program prints:
     ```
     No ingredients have been selected. Recipe will not be saved.
     ```

3. **Saving Recipes:**
   - Recipes are saved to a text file in either `.txt` or `.json` format. The file format is controlled by a `const` variable in the program.

   - **Text File (`.txt`) Format:**
     - Each line represents one recipe, with the ingredient IDs separated by commas:
       ```
       1,2,3
       1,2
       ```

   - **JSON File (`.json`) Format:**
     - Recipes are saved as an array of strings, where each string contains the ingredient IDs separated by commas:
       ```json
       ["1,2,3", "1,2"]
       ```

---

## 🥄 Ingredients

Ingredients are the core components of a recipe. Each ingredient has:
- **ID**: A unique identifier (e.g., 1 for Wheat Flour).
- **Name**: The name of the ingredient (e.g., Wheat Flour).
- **Preparation Instructions**: Steps to prepare the ingredient (e.g., "Sieve. Add to other ingredients.").

### Example Ingredients:

| ID  | Name            | Instruction                                               |
|-----|-----------------|-----------------------------------------------------------|
| 1   | Wheat Flour      | Sieve. Add to other ingredients.                          |
| 2   | Coconut Flour    | Sieve. Add to other ingredients.                          |
| 3   | Butter           | Melt on low heat. Add to other ingredients.                |
| 4   | Chocolate        | Melt in a water bath. Add to other ingredients.            |
| 5   | Sugar            | Add to other ingredients.                                 |
| 6   | Cardamom         | Take half a teaspoon. Add to other ingredients.            |
| 7   | Cinnamon         | Take half a teaspoon. Add to other ingredients.            |
| 8   | Cocoa Powder     | Add to other ingredients.                                 |

---

## 📘 Printing Existing Recipes

When the application starts and some recipes are already saved:
- The program loads the saved recipes from the text or JSON file and displays them.
- Each recipe is separated with a string: `*****{N}*****`, where `{N}` is the recipe number.

Example output:
Existing recipes are: 1 Wheat flour. Sieve. Add to other ingredients. Coconut flour. Sieve. Add to other ingredients. Butter. Melt on low heat. Add to other ingredients. 2 Butter. Melt on low heat. Add to other ingredients. Chocolate. Melt in a water bath. Add to other ingredients. Sugar. Add to other ingredients.

---

## 📜 Printing a Single Recipe

When printing a single recipe, each ingredient in the recipe is displayed on a separate line, followed by its preparation instructions.

Example:
Wheat flour. Sieve. Add to other ingredients. Coconut flour. Sieve. Add to other ingredients. Butter. Melt on low heat. Add to other ingredients.

---

## 💾 Storing Recipes in a Text File

Recipes are saved in either `.txt` or `.json` format, controlled by the developer's configuration:

- **Text File Format (.txt)**: Each line contains ingredient IDs for a recipe.
- **JSON File Format (.json)**: Each recipe is stored as a string of ingredient IDs in an array.

---

## 🍪 Selecting Ingredients for a New Recipe

After displaying the available ingredients, the user is prompted to select ingredients for the recipe:

Add an ingredient by its ID or type anything else if finished.

- The user enters an ingredient's ID to add it to the recipe.
- If an invalid ID is entered, the program will prompt the user again.
- If the user enters anything other than a valid ID, the ingredient selection process is finished.

---

## 🚪 Exiting the Application

After the user has finished creating or selecting a recipe, they can exit the application by pressing any key.

---


