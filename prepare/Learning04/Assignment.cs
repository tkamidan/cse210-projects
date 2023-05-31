public class Assignment {
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName() {
        return _studentName;
    }
}

public class MathAssignment : Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic) {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

public class WritingAssignment : Assignment {
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        _title = title;
    }

    public string GetWritingInformation() {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}