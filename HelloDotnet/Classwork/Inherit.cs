public string GetDetails(Person person)
{
    string result = string.Empty;
    if(person is Man)
    {
        Man man =  (Man) person;
        result = $"Id = {man.Id} Name = {man.name} playing = {man.Playing}";

    }
    if(person is Woman)
    {
        Woman woman = (Woman) person;
        result = $"Id = {woman.Id} Name = {woman.name} playing = {woman.Playing}";
    }
}