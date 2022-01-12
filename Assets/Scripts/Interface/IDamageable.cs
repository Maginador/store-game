namespace Interface
{
    public interface IDamageable
    {
        public void DoDamage(int damage);
        public void RecoverHealth(int recover);
        public void Die();
    }
}