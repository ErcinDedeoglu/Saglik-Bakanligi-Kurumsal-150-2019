﻿namespace JwtFinalQuiz.DTO
{
    public class UserDto
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
    }
}