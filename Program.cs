//*****************************************************************************
//** 1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence      **
//** leetcode problem easy.                                                  **
//*****************************************************************************

int isPrefixOfWord(char* sentence, char* searchWord) 
{
    int searchLen = strlen(searchWord);
    int sentenceLen = strlen(sentence);
    int wordIndex = 1; // Start at the first word
    int i = 0; // Index for traversing the sentence
    
    while(i < sentenceLen) 
    {
        // Check if the current word starts with searchWord
        int j = 0; // Reset prefix matching index for each word
        while(j < searchLen && i < sentenceLen && sentence[i] == searchWord[j]) 
        {
//            printf("Matching %c = %c\n",sentence[i],searchWord[j]);
            i++;
            j++;
        }
//        printf("J = %d , SearchLen = %d\n",j,searchLen);

        // If the entire searchWord is matched, return the current word index
        if(j == searchLen) 
        {
            return wordIndex;
        }

        // Skip the rest of the current word
        while(i < sentenceLen && sentence[i] != ' ') 
        {
            i++;
        }

        // Skip the space and move to the next word
        i++;
        wordIndex++;
    }

    // If no word matches, return -1
    return -1;
}