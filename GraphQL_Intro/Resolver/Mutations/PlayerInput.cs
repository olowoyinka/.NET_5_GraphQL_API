﻿namespace GraphQL_Intro.Resolver.Mutations
{
    public class PlayerInput
    {
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }
    }
}