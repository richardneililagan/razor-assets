using System;

namespace RazorAssets.Models
{
    public class Element
    {
        public string Id { get; private set; }
        public string Color { get; private set; }                

        // yeap, we're just trying to make some random element.
        public Element(Random random)
        {
            this.Id = "a" + Guid.NewGuid().ToString().Replace("-", "");
            this.Color = string.Format("#{0}{1}{2}",
                random.Next(0,255).ToString("X2"),
                random.Next(0,255).ToString("X2"),
                random.Next(0,255).ToString("X2")
                );
        }
    }
}