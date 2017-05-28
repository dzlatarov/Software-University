using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class ExceptionMessages
{
    public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";
    public const string DataAlreadyInitializedException = "Data is already initialized!";
    public const string DataNotInitializedExceptionMessage = "The data structure must be initialized first in order to make any operations with it.";
    public const string InexsistingStudentInDataBase = "The user name for the student you are trying to get does not exist!";
    public const string InexistingCourseInDataBase = "The course you are trying to get does not exis in the data base!";
    public const string IsQueryForStudentPossible = "The user name for student you are trying to get does not exist!";
    public const string InvalidPath = "The folder/file you are trying to access at the current address, does not exist.";
    public const string ComparisonofFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";
    public const string ForbiddenSymbolIsContained = "A frobidden symbol is contained.";
    public const string UnableToGoHigherInPartitionHierarchy = "Unable to go higher in partition hierarchy";
}

