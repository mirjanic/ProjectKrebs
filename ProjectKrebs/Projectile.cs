using System;
using System.Media;
using System.Drawing;

namespace ProjectKrebs
{
    /// <summary>
    /// Bukvalno sve što Ilja može da skupi od para do sockovih citata
    /// </summary>
    class Projectile : GraphicsElement
    {
        GameDataModifier OnHit;
        SoundPlayer Sp;
        int Lane;
        public Projectile(GameDataModifier OnHit, string Graphics, double Distance, int Lane, string Sound = "")
            : base(Graphics, Distance)
        {
            this.OnHit = OnHit;
            Sp = new SoundPlayer(Sound);
        }
        public void Hit(GameData gd)
        {
            OnHit(gd);
            Sp.Play();
        }
    }
}
